namespace WebApiGestion.Services
{
    using EF;

    public class Service : IService
    {
        public GestionStockContext DBContext { get; set; }
    }
}