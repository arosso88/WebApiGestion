namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public interface IBuilderDetalleComprobantesEmitidos
    {
        DetalleComprobantesEmitidos Generar(DetalleComprobantesEmitidosDto dceDto, Articulos articulo);
    }
}