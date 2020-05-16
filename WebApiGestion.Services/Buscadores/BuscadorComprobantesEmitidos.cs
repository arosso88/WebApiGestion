namespace WebApiGestion.Services.Buscadores
{
    using System.Collections.Generic;
    using System.Linq;
    using Domain;
    using Dtos;
    using EF;
    using QueryBuilders;

    public class BuscadorComprobantesEmitidos : BuscadorBase, IBuscadorComprobantesEmitidos
    {
        private readonly IComprobantesEmitidosQueryBuider queryBuider;

        public BuscadorComprobantesEmitidos(IComprobantesEmitidosQueryBuider queryBuider)
        {
            this.queryBuider = queryBuider;
        }

        public IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(GestionStockContext dbContext, FiltrosComprobantesEmitidosDto filtros)
        {
            var cem = dbContext.ComprobantesEmitidos.Where(this.queryBuider.GetTodosFiltrado(filtros));
            return cem;
        }
    }
}