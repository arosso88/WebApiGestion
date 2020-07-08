namespace WebApiGestion.Services.Generadores
{
    using EF;

    public interface IGeneradorBase
    {
        GestionStockContext DBContext { get; set; }
    }
}