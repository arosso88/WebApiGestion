namespace WebApiGestion.Services
{
    using EF;

    public interface IBuilder<T, TDto>
    {
        T BuildObjeto(IGestionStockContext uow, TDto dto);

        T BuildObjeto(IGestionStockContext uow, TDto dto, T objeto);
    }
}