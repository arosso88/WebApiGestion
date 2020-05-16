namespace WebApiGestion.Services
{
    using System.Collections.Generic;
    using Buscadores;
    using Dtos;
    using Domain;

    public class ServiceComprobantesEmitidos : ServiceT<ComprobantesEmitidos>, IServiceComprobantesEmitidos
    {
        private readonly IBuscadorComprobantesEmitidos buscador;

        public ServiceComprobantesEmitidos(IBuscadorComprobantesEmitidos buscador)
        {
            this.buscador = buscador;
        }

        public IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros) =>
            this.buscador.GetTodosFiltrado(this.DBContext, filtros);
    }
}