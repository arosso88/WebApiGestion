namespace WebApiGestion.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.Extensions.Options;

    [ApiController]
    [Route("[controller]")]
    public class SAUsuariosController : ControladorBaseController
    {
        private IServiceSAUsuarios serviceSAUsuarios;
        private string secret;
        private string issuer;
        private string audience;

        public SAUsuariosController(IServiceSAUsuarios serviceSAUsuarios, IOptions<AppSettings> settings)
        {
            this.serviceSAUsuarios = serviceSAUsuarios;
            this.secret = settings.Value.Secret;
            this.issuer = settings.Value.Issuer;
            this.audience = settings.Value.Audience;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Autenticar(Dtos.SA_UsuariosDto dto)
        {
            this.SetearDBContext(this.serviceSAUsuarios);

            var datosLoginDto = new Dtos.DatosLoginDto
            {
                Usuario = dto.usu_Usuario,
                Clave = dto.usu_Clave,
                Secret = this.secret,
                Issuer = this.issuer,
                Audience = this.audience
            };

            var user = this.serviceSAUsuarios.Autenticar(datosLoginDto);

            this.DisposeDBContext(this.serviceSAUsuarios.DBContext);

            if (user != null)
                return Ok(new { token = user.usu_Token });

            return StatusCode(401, "Error");
        }
    }
}