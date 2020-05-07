namespace WebApiGestion.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DetalleComprobantesEmitidos
    {
        [Key]
        public int dce_Id { get; set; }

        public int dce_cem_Id { get; set; }

        public int dce_art_Id { get; set; }

        public string dce_Descripcion { get; set; }

        public decimal dce_Cantidad { get; set; }

        public decimal dce_Precio { get; set; }

        public decimal dce_Importe { get; set; }

        public int dce_tmo_IdPrecio { get; set; }

        public int dce_ume_IdCantidad { get; set; }

        public int dce_ume_IdPrecio { get; set; }

        [ForeignKey(nameof(dce_cem_Id))]
        public virtual ComprobantesEmitidos ComprobantesEmitidos { get; set; }

        [ForeignKey(nameof(dce_art_Id))]
        public virtual Articulos Articulos { get; set; }

        [ForeignKey(nameof(dce_tmo_IdPrecio))]
        public virtual TiposMonedas TiposMonedas { get; set; }

        [ForeignKey(nameof(dce_ume_IdCantidad))]
        public virtual UnidadesMedida UnidadesMedidaCantidad { get; set; }

        [ForeignKey(nameof(dce_ume_IdPrecio))]
        public virtual UnidadesMedida UnidadesMedidaPrecio { get; set; }




    }
}