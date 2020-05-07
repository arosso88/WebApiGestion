namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class TiposMonedas
    {
        [Key]
        public int tmo_Id { get; set; }

        public string tmo_Descripcion { get; set; }

        public string tmo_Simbolo { get; set; }
    }
}