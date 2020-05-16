namespace WebApiGestion.Services.QueryBuilders
{
    using System;
    using System.Linq.Expressions;
    using Domain;
    using Dtos;
    using WebApiGestion.Shared;

    public class ComprobantesEmitidosQueryBuider : IComprobantesEmitidosQueryBuider
    {
        public Expression<Func<ComprobantesEmitidos, bool>> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros)
        {
            Expression<Func<ComprobantesEmitidos, bool>> result = result => true;

            if (!string.IsNullOrEmpty(filtros.EmitidoRecibido))
                result = result.And(x => x.TiposComprobantes.tco_EmitidoRecibido == filtros.EmitidoRecibido);

            return result;
        }
    }
}