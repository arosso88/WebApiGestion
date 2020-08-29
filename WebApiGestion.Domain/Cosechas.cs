namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Cosechas
    {
        [Key]
        public string pch_Id { get; set; }

        public string pch_Descripcion { get; set; }
    }
}