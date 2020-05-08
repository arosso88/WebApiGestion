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
    }
}