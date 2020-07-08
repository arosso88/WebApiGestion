namespace WebApiGestion.Services
{
    using System.Collections.Generic;
    using Buscadores;
    using Dtos;
    using Domain;
    using Builders;
    using Generadores;
    using System.Linq;

    public class ServiceComprobantesEmitidos : ServiceT<ComprobantesEmitidos>, IServiceComprobantesEmitidos
    {
        private readonly IBuscadorComprobantesEmitidos buscador;
        private readonly IBuscadorArticulos buscadorArticulos;

        private readonly IBuilderComprobantesEmitidos builderComprobantesEmitidos;
        private readonly IBuilderDetalleComprobantesEmitidos builderDetalleComprobantesEmitidos;

        private readonly IGeneradorDetalleIvaEmitidos generadorDIE;

        public ServiceComprobantesEmitidos(IBuscadorComprobantesEmitidos buscador
            , IBuilderComprobantesEmitidos builderComprobantesEmitidos
            , IBuilderDetalleComprobantesEmitidos builderDetalleComprobantesEmitidos
            , IBuscadorArticulos buscadorArticulos
            , IGeneradorDetalleIvaEmitidos generadorDIE)
        {
            this.buscador = buscador;
            this.buscadorArticulos = buscadorArticulos;

            this.builderComprobantesEmitidos = builderComprobantesEmitidos;
            this.builderDetalleComprobantesEmitidos = builderDetalleComprobantesEmitidos;

            this.generadorDIE = generadorDIE;
        }

        public IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros) =>
            this.buscador.GetTodosFiltrado(this.DBContext, filtros);

        public bool GuardarComprobanteEmitido(ComprobantesEmitidosDto cemDto)
        {
            var detalles = new List<DetalleComprobantesEmitidos>();
            decimal subtotal = 0;

            foreach (var dceDto in cemDto.detalle)
            {
                var articulo = this.buscadorArticulos.ObtenerUno(this.DBContext, dceDto.dce_art_Id);
                var dce = this.builderDetalleComprobantesEmitidos.Generar(dceDto, articulo);
                subtotal += dceDto.dce_Importe;
                detalles.Add(dce);
            }

            this.generadorDIE.DBContext = this.DBContext;
            var dies = this.generadorDIE.Generar(cemDto.detalle);

            var cem = this.builderComprobantesEmitidos.Generar(cemDto);
            cem.cem_ImporteSubtotal = subtotal;
            cem.cem_ImporteIva = dies.Sum(x => x.die_ImporteIva);
            cem.cem_ImporteTotal = cem.cem_ImporteSubtotal + cem.cem_ImporteIva;

            cem.DetalleComprobantesEmitidos = detalles;
            cem.DetalleIvaEmitidos = dies;

            this.DBContext.ComprobantesEmitidos.Add(cem);
            this.DBContext.SaveChanges();

            return true;
        }
    }
}