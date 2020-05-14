namespace WebApiGestion.Dtos
{
    public class TiposComprobantesDto
    {
        public int tco_Id { get; set; }

        public string tco_Codigo { get; set; }

        public string tco_Descripcion { get; set; }

        public string tco_Tipo { get; set; }

        public string tco_DebitoCreditoVdor { get; set; }

        public string tco_DebitoCreditoCdor { get; set; }

        public string tco_EmitidoRecibido { get; set; }

        public string DescripcionTNU { get; set; }

        public string tco_MovimientoStock { get; set; }

        public int tco_tnu_Id { get; set; }
    }
}