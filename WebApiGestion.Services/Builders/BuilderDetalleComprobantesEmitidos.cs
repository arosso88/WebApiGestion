namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public class BuilderDetalleComprobantesEmitidos : IBuilderDetalleComprobantesEmitidos
    {
        public DetalleComprobantesEmitidos Generar(DetalleComprobantesEmitidosDto dceDto, Articulos articulo)
        {
            var dce = new DetalleComprobantesEmitidos
            {
                dce_art_Id = dceDto.dce_art_Id,
                dce_Cantidad = dceDto.dce_Cantidad,
                dce_Descripcion = articulo.art_Descripcion,
                dce_Importe = dceDto.dce_Importe,
                dce_Precio = dceDto.dce_Precio,
                dce_tmo_IdPrecio = dceDto.dce_tmo_IdPrecio,
                dce_ume_IdCantidad = articulo.art_ume_Id,
                dce_ume_IdPrecio = articulo.art_ume_Id
            };

            return dce;
        }
    }
}