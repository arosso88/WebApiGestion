namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TiposComprobantes
    {
        [Key]
        public int tco_Id { get; set; }

        public string tco_Codigo { get; set; }

        public string tco_Descripcion { get; set; }

        public string tco_Tipo { get; set; }

        public string tco_DebitoCreditoVdor { get; set; }

        public string tco_DebitoCreditoCdor { get; set; }

        public int tco_tnu_Id { get; set; }

        public string tco_EmitidoRecibido { get; set; }

        public string tco_MovimientoStock { get; set; }

        [ForeignKey(nameof(tco_tnu_Id))]
        public virtual TablasNumeracion TablasNumeracion { get; set; }
    }
}