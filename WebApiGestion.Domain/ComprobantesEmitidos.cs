namespace WebApiGestion.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ComprobantesEmitidos
    {
        [Key]
        public int cem_Id { get; set; }

        public int cem_tco_Id { get; set; }

        public int? cem_cli_IdVendedor { get; set; }

        public int? cem_cli_IdComprador { get; set; }

        public DateTime cem_FechaEmision { get; set; }

        public decimal cem_ImporteSubtotal { get; set; }

        public decimal cem_ImporteIva { get; set; }

        public decimal cem_ImporteTotal { get; set; }

        public int cem_tmo_Id { get; set; }

        public int cem_NroPuntoVenta { get; set; }

        public int cem_NroComprobante { get; set; }

        public string cem_Letra { get; set; }

        [ForeignKey(nameof(cem_tco_Id))]
        public virtual TiposComprobantes TiposComprobantes { get; set; }

        [ForeignKey(nameof(cem_cli_IdComprador))]
        public virtual Clientes Comprador { get; set; }

        [ForeignKey(nameof(cem_cli_IdVendedor))]
        public virtual Clientes Vendedor { get; set; }

        [ForeignKey(nameof(cem_tmo_Id))]
        public virtual TiposMonedas TiposMonedas { get; set; }

        public virtual ICollection<DetalleComprobantesEmitidos> DetalleComprobantesEmitidos { get; set; }

        public virtual ICollection<DetalleIvaEmitido> DetalleIvaEmitidos { get; set; }
    }
}