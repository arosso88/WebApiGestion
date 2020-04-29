namespace WebApiGestion.Services
{
    using Buscadores;

    public class ServiceSAUsuarios : ServiceT<Domain.SA_Usuarios>, IServiceSAUsuarios
    {
        private IBuscadorSAUsuarios buscador;
        private IGeneradorToken generadorToken;

        public ServiceSAUsuarios(IBuscadorSAUsuarios buscador, IGeneradorToken generadorToken)
        {
            this.buscador = buscador;
            this.generadorToken = generadorToken;
        }

        public Domain.SA_Usuarios Autenticar(Dtos.DatosLoginDto datosLoginDto)
        {
            var user = this.buscador.GetSAUsuario(datosLoginDto.Usuario, datosLoginDto.Clave, this.DBContext);

            if (user == null)
                return null;

            datosLoginDto.IdUsuario = user.usu_Id;

            user.usu_Token = this.generadorToken.GenerarToken(datosLoginDto);

            this.DBContext.SaveChanges();

            return user;
        }
    }
}