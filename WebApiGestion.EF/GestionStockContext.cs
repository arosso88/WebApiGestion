namespace WebApiGestion.EF
{
    using Microsoft.EntityFrameworkCore;
    using Domain;

    public class GestionStockContext : DbContext, IGestionStockContext
    {
        public GestionStockContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public DbSet<Articulos> Articulos { get; set; }

        public DbSet<UnidadesMedida> UnidadesMedida { get; set; }

        public DbSet<SA_Usuarios> SA_Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
