namespace WebApiGestion.Services.Buscadores
{
    using System.Collections.Generic;
    using System.Linq;
    using Domain;
    using Dtos;
    using EF;
    using QueryBuilders;

    public class BuscadorTiposComprobantes : BuscadorBase, IBuscadorTiposComprobantes
    {
        private readonly ITiposComprobantesQueryBuilder queryBuilder;

        public BuscadorTiposComprobantes(ITiposComprobantesQueryBuilder queryBuilder)
        {
            this.queryBuilder = queryBuilder;
        }

        public IEnumerable<TiposComprobantes> GetFiltrado(GestionStockContext dbContext, FiltrosTiposComprobantesDto filtros) =>
            dbContext.TiposComprobantes.Where(queryBuilder.GetFiltrado(filtros));
    }
}