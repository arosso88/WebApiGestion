namespace WebApiGestion.EF
{
    using Microsoft.EntityFrameworkCore;
    using Domain;

    public interface IGestionStockContext 
    {
        DbSet<Articulos> Articulos { get; set; }

        DbSet<UnidadesMedida> UnidadesMedida { get; set; }

        DbSet<SA_Usuarios> SA_Usuarios { get; set; }

        DbSet<TiposMonedas> TiposMonedas { get; set; }

        DbSet<CategoriasIvaArticulo> CategoriasIvaArticulo { get; set; }

        DbSet<Clientes> Clientes { get; set; }

        DbSet<TiposComprobantes> TiposComprobantes { get; set; }

        DbSet<ComprobantesEmitidos> ComprobantesEmitidos { get; set; }

        DbSet<DetalleComprobantesEmitidos> DetalleComprobantesEmitidos { get; set; }

        DbSet<TablasNumeracion> TablasNumeracion { get; set; }
    }
}
