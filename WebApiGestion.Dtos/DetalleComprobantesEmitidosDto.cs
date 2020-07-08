namespace WebApiGestion.Dtos
{
    public class DetalleComprobantesEmitidosDto
    {
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
    }
}