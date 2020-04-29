namespace WebApiGestion.Services.Buscadores
{
    using System.Linq;
    using QueryBuilders;
    using WebApiGestion.Domain;

    public class BuscadorSAUsuarios : BuscadorBase, IBuscadorSAUsuarios
    {
        private ISAUsuariosQueryBuilder queryBuilder;

        public BuscadorSAUsuarios(ISAUsuariosQueryBuilder queryBuilder)
        {
            this.queryBuilder = queryBuilder;
        }

        public Domain.SA_Usuarios GetSAUsuario(string usuario, string clave, EF.GestionStockContext dbContext) =>
            dbContext.SA_Usuarios.SingleOrDefault(this.queryBuilder.GetUsuario(usuario, clave));
    }
}