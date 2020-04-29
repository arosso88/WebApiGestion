namespace WebApiGestion.Services
{
    using AutoMapper;
    using EF;

    public class Builder<T, TDto> : IBuilder<T, TDto>
    {
        public T BuildObjeto(IGestionStockContext uow, TDto dto)
        {
            var objeto = this.GetObjeto(dto);
            this.GuardadosAdicionales(uow, objeto, dto);
            return objeto;
        }

        public T BuildObjeto(IGestionStockContext uow, TDto dto, T objeto)
        {
            Mapper.CreateMap<TDto, T>();
            Mapper.Map(dto, objeto);

            this.GuardadosAdicionales(uow, objeto, dto);
            return objeto;
        }

        protected virtual T GetObjeto(TDto dto)
        {
            Mapper.CreateMap<TDto, T>();
            return Mapper.Map<T>(dto);
        }

        protected virtual void GuardadosAdicionales(IGestionStockContext unitOfWork, T objeto, TDto dto)
        {
            // hook method
        }
    }
}
