namespace WebApiGestion.Dtos
{
    public class NuevoCEMDto
    {
        public int tcoId { get; set; }

        public int ptoVenta { get; set; }

        public int nro { get; set; }

        public string letra { get; set; }

        public System.DateTime fecha { get; set; }

        public int cliIdComprador { get; set; }

        public int moneda { get; set; }

        public System.Collections.Generic.List<DetalleCEMDto> Detalle { get; set; }
    }
}