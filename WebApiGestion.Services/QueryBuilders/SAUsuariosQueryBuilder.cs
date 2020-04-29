namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;

    public class SAUsuariosQueryBuilder : ISAUsuariosQueryBuilder
    {
        public Expression<Func<Domain.SA_Usuarios, bool>> GetUsuario(string usuario, string clave) =>
            x => x.usu_Usuario == usuario && x.usu_Clave == clave;
    }
}