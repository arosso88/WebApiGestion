namespace WebApiGestion.Domain
{
    public partial class ComprobantesEmitidos
    {
        public string TcoCodigo { get => this.TiposComprobantes.tco_Codigo; }

        public int? CodigoComprador { get => this.Comprador?.cli_clc_Codigo; }

        public string NombreComprador 
        { 
            get => string.Concat(this.Comprador?.cli_Nombre, " ", this.Comprador?.cli_Apellido); 
        }

        public int? CodigoVendedor { get => this.Vendedor?.cli_clc_Codigo; }

        public string NombreVendedor
        {
            get => string.Concat(this.Vendedor?.cli_Nombre, " ", this.Vendedor?.cli_Apellido);
        }

        public string SimboloMoneda { get => this.TiposMonedas.tmo_Simbolo; }
    }
}