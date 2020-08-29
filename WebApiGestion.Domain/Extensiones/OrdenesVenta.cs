namespace WebApiGestion.Domain
{
    public partial class OrdenesVenta
    {
        public string NombreComprador 
        { 
            get => string.Concat(this.Comprador.cli_Nombre, " ", this.Comprador.cli_Apellido); 
        }

        public string NombreVendedor
        {
            get => string.Concat(this.Vendedor.cli_Nombre, " ", this.Vendedor.cli_Apellido);
        }

        public string Moneda { get => this.TiposMonedas.tmo_Simbolo; }

    }
}