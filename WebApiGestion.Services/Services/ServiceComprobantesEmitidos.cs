namespace WebApiGestion.Services
{
    using System.Collections.Generic;
    using Buscadores;
    using Dtos;
    using Domain;
    using Builders;

    public class ServiceComprobantesEmitidos : ServiceT<ComprobantesEmitidos>, IServiceComprobantesEmitidos
    {
        private readonly IBuscadorComprobantesEmitidos buscador;
        private readonly IBuscadorArticulos buscadorArticulos;

        private readonly IBuilderComprobantesEmitidos builderComprobantesEmitidos;
        private readonly IBuilderDetalleComprobantesEmitidos builderDetalleComprobantesEmitidos;

        public ServiceComprobantesEmitidos(IBuscadorComprobantesEmitidos buscador
            , IBuilderComprobantesEmitidos builderComprobantesEmitidos
            , IBuilderDetalleComprobantesEmitidos builderDetalleComprobantesEmitidos
            , IBuscadorArticulos buscadorArticulos)
        {
            this.buscador = buscador;
            this.buscadorArticulos = buscadorArticulos;

            this.builderComprobantesEmitidos = builderComprobantesEmitidos;
            this.builderDetalleComprobantesEmitidos = builderDetalleComprobantesEmitidos;
        }

        public IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros) =>
            this.buscador.GetTodosFiltrado(this.DBContext, filtros);

        public bool GuardarComprobanteEmitido(NuevoCEMDto dto)
        {
            var detalles = new List<DetalleComprobantesEmitidos>();
            var dicIva = new Dictionary<int, DetalleIvaEmitidoDto>();
            decimal subtotal = 0;

            foreach (var det in dto.Detalle)
            {
                var articulo = this.buscadorArticulos.ObtenerUno(this.DBContext, det.artId);
                var dce = this.builderDetalleComprobantesEmitidos.Generar(det, articulo, dto.moneda);
                subtotal += det.importe;
                detalles.Add(dce);

                if (!dicIva.ContainsKey(articulo.art_cia_Id))
                {
                    var dieDto = new DetalleIvaEmitidoDto
                    {
                        die_cia_Id = articulo.art_cia_Id,
                        die_ImponibleIva = det.importe,
                        die_PorcentajeIva = articulo.CategoriasIvaArticulo.cia_PorcentajeIva,
                        die_ImporteIva = this.GetImporteIva(det.importe, articulo.CategoriasIvaArticulo.cia_PorcentajeIva)
                    };

                    dicIva.Add(articulo.art_cia_Id, dieDto);
                }
                else
                {
                    var dieDto = dicIva.GetValueOrDefault(articulo.art_cia_Id);
                    dicIva.Remove(articulo.art_cia_Id);

                    dieDto.die_ImponibleIva += det.importe;
                    dieDto.die_ImporteIva += this.GetImporteIva(det.importe, articulo.CategoriasIvaArticulo.cia_PorcentajeIva);

                    dicIva.Add(articulo.art_cia_Id, dieDto);
                }
            }

            var cem = this.builderComprobantesEmitidos.Generar(dto);
            cem.DetalleComprobantesEmitidos = detalles;

            this.DBContext.ComprobantesEmitidos.Add(cem);
            this.DBContext.SaveChanges();

            return true;
        }

        private decimal GetImporteIva(decimal importe, decimal porcentajeIva) => importe * porcentajeIva / 100;
    }
}