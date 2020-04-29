namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class SA_Usuarios
    {
        [Key]
        public int usu_Id { get; set; }

        public string usu_Nombre { get; set; }

        public string usu_Usuario { get; set; }

        public string usu_Clave { get; set; }

        public string usu_Token { get; set; }
    }
}