namespace WebApiGestion.Domain
{
    public partial class DetalleComprobantesEmitidos
    {
        public string CodigoArticulo { get => this.Articulos.art_Codigo; }

        public string DescripcionArticulo { get => this.Articulos.art_Descripcion; }

        public string SimboloMoneda { get => this.TiposMonedas.tmo_Simbolo; }

        public string UMECantidadCodigo { get => this.UnidadesMedidaCantidad.ume_Codigo; }

        public string UMEPrecioCodigo { get => this.UnidadesMedidaPrecio.ume_Codigo; }
    }
}