namespace WebApiGestion.Services
{
    using System.Collections.Generic;
    using Domain;
    using Dtos;
    using Buscadores;

    public class ServiceTiposComprobantes : ServiceT<TiposComprobantes>, IServiceTiposComprobantes
    {
        private readonly IBuscadorTiposComprobantes buscador;

        public ServiceTiposComprobantes(IBuscadorTiposComprobantes buscador)
        {
            this.buscador = buscador;
        }

        public IEnumerable<TiposComprobantes> GetTodosFiltrado(FiltrosTiposComprobantesDto filtros) =>
            this.buscador.GetFiltrado(this.DBContext, filtros);
    }
}