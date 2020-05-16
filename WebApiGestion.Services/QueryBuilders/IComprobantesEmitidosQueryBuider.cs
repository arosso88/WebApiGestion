namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;
    using Domain;
    using Dtos;

    public interface IComprobantesEmitidosQueryBuider
    {
        Expression<Func<ComprobantesEmitidos, bool>> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros);
    }
}