namespace WebApiGestion.EF
{
    using Microsoft.EntityFrameworkCore;
    using Domain;

    public interface IGestionStockContext 
    {
        DbSet<Articulos> Articulos { get; set; }

        DbSet<UnidadesMedida> UnidadesMedida { get; set; }

        DbSet<SA_Usuarios> SA_Usuarios { get; set; }
    }
}
