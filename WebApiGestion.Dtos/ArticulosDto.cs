namespace WebApiGestion.Dtos
{
    public class ArticulosDto
    {
        public int art_Id { get; set; }

        public string art_Codigo { get; set; }

        public string art_Descripcion { get; set; }

        public int art_ume_Id { get; set; }

        public int art_cia_Id { get; set; }

        public string CodigoUME { get; set; }

        public string DescripcionUME { get; set; }

        public string DescripcionCIA { get; set; }

        public decimal PorcentajeIva { get; set; }
    }
}