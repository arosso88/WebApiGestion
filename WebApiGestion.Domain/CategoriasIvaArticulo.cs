namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class CategoriasIvaArticulo
    {
        [Key]
        public int cia_Id { get; set; }

        public string cia_Descripcion { get; set; }

        public decimal cia_PorcentajeIva { get; set; }
    }
}