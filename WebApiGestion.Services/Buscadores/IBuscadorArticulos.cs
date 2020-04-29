namespace WebApiGestion.Services.Buscadores
{
    using EF;
    using Domain;

    public interface IBuscadorArticulos : IBuscadorBase
    {
        Articulos ObtenerUno(GestionStockContext dbContext, int id);
    }
}