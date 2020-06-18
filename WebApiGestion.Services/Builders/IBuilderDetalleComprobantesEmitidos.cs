namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public interface IBuilderDetalleComprobantesEmitidos
    {
        DetalleComprobantesEmitidos Generar(DetalleCEMDto dto, Articulos articulo, int tmoId);
    }
}