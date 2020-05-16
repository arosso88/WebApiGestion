namespace WebApiGestion.Services.Buscadores
{
    using System.Collections.Generic;
    using Domain;
    using Dtos;
    using EF;

    public interface IBuscadorComprobantesEmitidos : IBuscadorBase
    {
        IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(GestionStockContext dbContext, FiltrosComprobantesEmitidosDto filtros);
    }
}
