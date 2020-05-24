namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;
    using Dtos;
    using Domain;

    public interface ITiposComprobantesQueryBuilder
    {
        Expression<Func<TiposComprobantes, bool>> GetFiltrado(FiltrosTiposComprobantesDto filtros);
    }
}