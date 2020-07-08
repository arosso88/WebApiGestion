namespace WebApiGestion.Services.Generadores
{
    public class GeneradorBase : IGeneradorBase
    {
        public EF.GestionStockContext DBContext { get; set; }
    }
}