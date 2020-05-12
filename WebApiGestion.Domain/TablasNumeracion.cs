namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class TablasNumeracion
    {
        [Key]
        public int tnu_Id { get; set; }

        public string tnu_Descripcion { get; set; }

        public int tnu_NroPuntoVenta { get; set; }

        public int tnu_NroComprobante { get; set; }

        public string tnu_Letra { get; set; }
    }
}