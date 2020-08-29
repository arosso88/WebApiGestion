namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Productos
    {
        [Key]
        public string pdu_Id { get; set; }

        public string pdu_Descripcion { get; set; }
    }
}