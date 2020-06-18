namespace WebApiGestion.Services.Builders
{
    public interface IBuilderComprobantesEmitidos
    {
        Domain.ComprobantesEmitidos Generar(Dtos.NuevoCEMDto dto);
    }
}