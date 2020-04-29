namespace WebApiGestion.Services
{
    using EF;

    public interface IContextManager
    {
        GestionStockContext GetDBContext(string servidor, string db);

        void DisposeDBContext(GestionStockContext context);
    }
}
