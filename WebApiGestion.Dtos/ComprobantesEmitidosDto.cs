namespace WebApiGestion.Dtos
{
    using System;

    public class ComprobantesEmitidosDto
    {
        public int cem_Id { get; set; }

        public int cem_tco_Id { get; set; }

        public int? cem_cli_IdVendedor { get; set; }

        public int? cem_cli_IdComprador { get; set; }

        public DateTime cem_FechaEmision { get; set; }

        public decimal cem_ImporteSubtotal { get; set; }

        public decimal cem_ImporteIva { get; set; }

        public decimal cem_ImporteTotal { get; set; }

        public int cem_tmo_Id { get; set; }

        public string TcoCodigo { get; set; }

        public int? CodigoComprador { get; set; }

        public string NombreComprador { get; set; }

        public int? CodigoVendedor { get; set; }

        public string NombreVendedor { get; set; }

        public string SimboloMoneda { get; set; }

        public int cem_NroPuntoVenta { get; set; }

        public int cem_NroComprobante { get; set; }

        public string cem_Letra { get; set; }
    }
}