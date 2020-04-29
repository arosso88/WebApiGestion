namespace WebApiGestion.Services
{
    public interface IGeneradorToken
    {
        string GenerarToken(Dtos.DatosLoginDto dto);
    }
}