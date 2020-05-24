namespace WebApiGestion.Services.Buscadores
{
    using System.Collections.Generic;
    using Domain;
    using Dtos;
    using EF;

    public interface IBuscadorTiposComprobantes : IBuscadorBase
    {
        IEnumerable<TiposComprobantes> GetFiltrado(GestionStockContext dbContext, FiltrosTiposComprobantesDto filtros);
    }
}