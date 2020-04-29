namespace WebApiGestion.Domain
{
    public partial class Articulos
    {
        public string CodigoUME { get => this.UnidadesMedida.ume_Codigo; }

        public string DescripcionUME { get => this.UnidadesMedida.ume_Descripcion; }
    }
}
