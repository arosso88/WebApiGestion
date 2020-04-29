namespace WebApiGestion.Services
{
    public class IdIdentificator<T> : IIdIdentificator<T>
    {
        public string GetIdName()
        {
            var id2 = string.Empty;

            foreach (var property in typeof(T).GetProperties())
                if (IsId(property.Name))
                    return property.Name;
                else if (IsId2(property.Name))
                    id2 = property.Name;

            if (string.IsNullOrEmpty(id2))
                throw new ClaseNoIdentificableException();

            return id2;
        }

        private static bool IsId(string propertyName)
        {
            if (propertyName.Split('_').Length > 2)
                return false;

            return propertyName.EndsWith("_Id");
        }

        private static bool IsId2(string propertyName)
        {
            return propertyName.StartsWith("Id_");
        }
    }
}