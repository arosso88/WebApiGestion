namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;
    using Domain;
    using Dtos;
    using Shared;

    public class TiposComprobantesQueryBuilder : ITiposComprobantesQueryBuilder
    {
        public Expression<Func<TiposComprobantes, bool>> GetFiltrado(FiltrosTiposComprobantesDto filtros)
        {
            Expression<Func<TiposComprobantes, bool>> result = result => true;

            if (!string.IsNullOrEmpty(filtros.EmitidoRecibido))
                result = result.And(x => x.tco_EmitidoRecibido == filtros.EmitidoRecibido);

            return result;
        }
    }
}