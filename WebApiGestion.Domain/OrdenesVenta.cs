namespace WebApiGestion.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class OrdenesVenta
    {
        [Key]
        public int ove_Id { get; set; }

        public string ove_Codigo { get; set; }

        public int ove_cli_IdVendedor { get; set; }

        public int ove_cli_IdComprador { get; set; }

        public string ove_pdu_Id { get; set; }

        public string ove_pch_Id { get; set; }

        public decimal ove_Precio { get; set; }

        public int ove_tmo_IdPrecio { get; set; }

        public int ove_KgPactados { get; set; }

        public string ove_Observaciones { get; set; }

        public DateTime ove_FechaNegocio { get; set; }

        [ForeignKey(nameof(ove_cli_IdComprador))]
        public virtual Clientes Comprador { get; set; }

        [ForeignKey(nameof(ove_cli_IdVendedor))]
        public virtual Clientes Vendedor { get; set; }

        [ForeignKey(nameof(ove_pdu_Id))]
        public virtual Productos Productos { get; set; }

        [ForeignKey(nameof(ove_pch_Id))]
        public virtual Cosechas Cosechas { get; set; }

        [ForeignKey(nameof(ove_tmo_IdPrecio))]
        public virtual TiposMonedas TiposMonedas { get; set; }
    }
}