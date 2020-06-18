namespace WebApiGestion.Services.Builders
{
    using Domain;
    using Dtos;

    public class BuilderComprobantesEmitidos : IBuilderComprobantesEmitidos
    {
        public ComprobantesEmitidos Generar(NuevoCEMDto dto)
        {
            var cem = new ComprobantesEmitidos
            {
                cem_tco_Id = dto.tcoId,
                cem_cli_IdComprador = dto.cliIdComprador,
                cem_FechaEmision = dto.fecha,
                cem_tmo_Id = dto.moneda,
                cem_NroPuntoVenta = dto.ptoVenta,
                cem_NroComprobante = dto.nro,
                cem_Letra = dto.letra
            };

            return cem;
        }
    }
}