namespace WebApiGestion.Services.Buscadores
{
    public interface IBuscadorSAUsuarios : IBuscadorBase
    {
        Domain.SA_Usuarios GetSAUsuario(string usuario, string clave, EF.GestionStockContext dbContext);
    }
}