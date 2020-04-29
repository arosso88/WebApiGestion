namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Articulos
    {
        [Key]
        public int art_Id { get; set; }

        public string art_Codigo { get; set; }

        public string art_Descripcion { get; set; }

        public int art_ume_Id { get; set; }

        [ForeignKey(nameof(art_ume_Id))]
        public virtual UnidadesMedida UnidadesMedida { get; set; }
    }
}
