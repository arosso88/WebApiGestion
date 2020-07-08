namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public class BuilderComprobantesEmitidos : IBuilderComprobantesEmitidos
    {
        public ComprobantesEmitidos Generar(ComprobantesEmitidosDto cemDto)
        {
            var cem = new ComprobantesEmitidos
            {
                cem_tco_Id = cemDto.cem_tco_Id,
                cem_cli_IdComprador = cemDto.cem_cli_IdComprador,
                cem_FechaEmision = cemDto.cem_FechaEmision,
                cem_tmo_Id = cemDto.cem_tmo_Id,
                cem_NroPuntoVenta = cemDto.cem_NroPuntoVenta,
                cem_NroComprobante = cemDto.cem_NroComprobante,
                cem_Letra = cemDto.cem_Letra
            };

            return cem;
        }
    }
}