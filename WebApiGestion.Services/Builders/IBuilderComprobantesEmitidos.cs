namespace WebApiGestion.Services.Builders
{
    using Dtos;
    using Domain;

    public interface IBuilderComprobantesEmitidos
    {
        ComprobantesEmitidos Generar(ComprobantesEmitidosDto cemDto);
    }
}