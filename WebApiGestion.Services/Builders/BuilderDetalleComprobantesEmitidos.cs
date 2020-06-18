namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public class BuilderDetalleComprobantesEmitidos : IBuilderDetalleComprobantesEmitidos
    {
        public DetalleComprobantesEmitidos Generar(DetalleCEMDto dto, Articulos articulo, int tmoId)
        {
            var dce = new DetalleComprobantesEmitidos
            {
                dce_art_Id = dto.artId,
                dce_Cantidad = dto.cantidad,
                dce_Descripcion = articulo.art_Descripcion,
                dce_Importe = dto.importe,
                dce_Precio = dto.precio,
                dce_tmo_IdPrecio = tmoId,
                dce_ume_IdCantidad = articulo.art_ume_Id,
                dce_ume_IdPrecio = articulo.art_ume_Id
            };

            return dce;
        }
    }
}