namespace WebApiGestion.Services
{
    using Domain;
    using System.Collections.Generic;
    using Dtos;

    public interface IServiceComprobantesEmitidos : IServiceT<ComprobantesEmitidos>
    {
        IEnumerable<ComprobantesEmitidos> GetTodosFiltrado(FiltrosComprobantesEmitidosDto filtros);

        bool GuardarComprobanteEmitido(NuevoCEMDto dto);
    }
}