namespace WebApiGestion.Services.Generadores
{
    using System.Collections.Generic;
    using Buscadores;
    using Dtos;
    using Domain;

    public class GeneradorDetalleIvaEmitidos : GeneradorBase, IGeneradorDetalleIvaEmitidos
    {
        private readonly IBuscadorArticulos buscadorArticulos;

        public GeneradorDetalleIvaEmitidos(IBuscadorArticulos buscadorArticulos)
        {
            this.buscadorArticulos = buscadorArticulos;
        }

        public List<DetalleIvaEmitido> Generar(List<DetalleComprobantesEmitidosDto> dceDtos)
        {
            var dicIva = new Dictionary<int, DetalleIvaEmitidoDto>();
            var dies = new List<DetalleIvaEmitido>();

            foreach (var dceDto in dceDtos)
            {
                var articulo = this.buscadorArticulos.ObtenerUno(this.DBContext, dceDto.dce_art_Id);

                if (!dicIva.ContainsKey(articulo.art_cia_Id))
                {
                    var dieDto = new DetalleIvaEmitidoDto
                    {
                        die_cia_Id = articulo.art_cia_Id,
                        die_ImponibleIva = dceDto.dce_Importe,
                        die_PorcentajeIva = articulo.CategoriasIvaArticulo.cia_PorcentajeIva,
                        die_ImporteIva = this.GetImporteIva(dceDto.dce_Importe, articulo.CategoriasIvaArticulo.cia_PorcentajeIva)
                    };

                    dicIva.Add(articulo.art_cia_Id, dieDto);
                }
                else
                {
                    var dieDto = dicIva.GetValueOrDefault(articulo.art_cia_Id);
                    dicIva.Remove(articulo.art_cia_Id);

                    dieDto.die_ImponibleIva += dceDto.dce_Importe;
                    dieDto.die_ImporteIva += this.GetImporteIva(dceDto.dce_Importe, articulo.CategoriasIvaArticulo.cia_PorcentajeIva);

                    dicIva.Add(articulo.art_cia_Id, dieDto);
                }
            }

            foreach (var iva in dicIva.Values)
            {
                dies.Add(new DetalleIvaEmitido
                {
                    die_cia_Id = iva.die_cia_Id,
                    die_ImponibleIva = iva.die_ImponibleIva,
                    die_ImporteIva = iva.die_ImporteIva,
                    die_PorcentajeIva = iva.die_PorcentajeIva
                });
            }

            return dies;
        }

        private decimal GetImporteIva(decimal importe, decimal porcentajeIva) => importe * porcentajeIva / 100;
    }
}
