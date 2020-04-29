namespace WebApiGestion.Services
{
    public interface IServiceSAUsuarios : IServiceT<Domain.SA_Usuarios>
    {
        Domain.SA_Usuarios Autenticar(Dtos.DatosLoginDto datosLoginDto);
    }
}