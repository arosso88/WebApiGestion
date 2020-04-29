namespace WebApiGestion.Dtos
{
    public class DatosLoginDto
    {
        public string Usuario { get; set; }

        public string Clave { get; set; }

        public string Secret { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public int IdUsuario { get; set; }
    }
}
