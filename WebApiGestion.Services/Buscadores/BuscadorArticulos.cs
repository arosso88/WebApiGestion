namespace WebApiGestion.Services.Buscadores
{
    using Domain;
    using EF;
    using System.Linq;

    public class BuscadorArticulos : BuscadorBase, IBuscadorArticulos
    {
        public Articulos ObtenerUno(GestionStockContext dbContext, int id) =>
            dbContext.Articulos.Single(x => x.art_Id == id);
    }
}