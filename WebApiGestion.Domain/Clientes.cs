namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Clientes
    {
        [Key]
        public int cli_Id { get; set; }

        public int cli_clc_Codigo { get; set; }

        public string cli_Nombre { get; set; }

        public string cli_Apellido { get; set; }

        public string cli_Direccion { get; set; }
    }
}