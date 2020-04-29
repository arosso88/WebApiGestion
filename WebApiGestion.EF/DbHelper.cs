namespace WebApiGestion.EF
{
    public class DbHelper
    {
        public static GestionStockContext GetDBContext(string servidor, string DB)
        {
            var connectionString = string.Concat("Data Source=", servidor, ";Initial Catalog=", DB, ";Persist Security Info=True;User ID=Andres;Password=12691269;");
            return new GestionStockContext(connectionString);
        }
    }
}
