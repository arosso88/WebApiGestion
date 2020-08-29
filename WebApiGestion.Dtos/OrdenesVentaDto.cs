namespace WebApiGestion.Dtos
{
    using System;

    public class OrdenesVentaDto
    {
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

        public string NombreComprador { get; set; }

        public string NombreVendedor { get; set; }

        public string Moneda { get; set; }
    }
}