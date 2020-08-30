namespace WebApiGestion.Services
{
    using System.Collections.Generic;

    public interface IServiceT<T> : IService
    {
        IEnumerable<T> ObtenerTodos();

        T ObtenerPorId(object id);

        void Eliminar(object id);

        void Agregar<TDto>(TDto dto) where TDto : class;

        bool Modificar<TDto>(TDto dto) where TDto : class;
    }
}