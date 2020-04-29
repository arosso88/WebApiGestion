namespace WebApiGestion.Services
{
    using System;

    [Serializable]
    public class ClaseNoIdentificableException : Exception
    {
        public ClaseNoIdentificableException()
            : base("La clase provista no tiene un id identificable")
        {
        }
    }
}