namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;

    public interface ISAUsuariosQueryBuilder
    {
        Expression<Func<Domain.SA_Usuarios, bool>> GetUsuario(string usuario, string clave);
    }
}