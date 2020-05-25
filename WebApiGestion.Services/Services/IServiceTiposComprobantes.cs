namespace WebApiGestion.Services
{
    using System.Collections.Generic;
    using Domain;
    using Dtos;

    public interface IServiceTiposComprobantes : IServiceT<TiposComprobantes>
    {
        IEnumerable<TiposComprobantes> GetTodosFiltrado(FiltrosTiposComprobantesDto filtros);
    }
}