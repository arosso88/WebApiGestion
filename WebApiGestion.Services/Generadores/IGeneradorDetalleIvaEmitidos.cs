namespace WebApiGestion.Services.Generadores
{
    using Domain;
    using Dtos;
    using System.Collections.Generic;

    public interface IGeneradorDetalleIvaEmitidos : IGeneradorBase
    {
        List<DetalleIvaEmitido> Generar(List<DetalleComprobantesEmitidosDto> dceDtos);
    }
}