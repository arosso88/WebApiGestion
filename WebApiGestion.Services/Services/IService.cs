namespace WebApiGestion.Services
{
    using EF;

    public interface IService
    {
        GestionStockContext DBContext { get; set; }
    }
}