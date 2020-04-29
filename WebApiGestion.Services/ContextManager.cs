namespace WebApiGestion.Services
{
    using EF;

    public class ContextManager : IContextManager
    {
        public GestionStockContext GetDBContext(string servidor, string db)
        {
            var context = EF.DbHelper.GetDBContext(servidor, db);
            return context;
        }

        public void DisposeDBContext(GestionStockContext context) => context.Dispose();
    }
}
