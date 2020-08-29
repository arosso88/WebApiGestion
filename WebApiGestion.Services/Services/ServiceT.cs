namespace WebApiGestion.Services
{
    using AutoMapper;
    using System.Collections.Generic;
    using System.Linq;
    using EF;
    using Microsoft.EntityFrameworkCore;

    public class ServiceT<T> : Service, IServiceT<T> where T : class
    {
        public IEnumerable<T> ObtenerTodos() => this.DBContext.Set<T>().ToArray();

        public T ObtenerPorId(int id) => this.ObtenerObjeto(id, this.DBContext);

        public void Eliminar(object id)
        {
            var dbSet = this.DBContext.Set<T>();
            var objeto = this.DBContext.Set<T>().Find(id);
            dbSet.Remove(objeto);
            this.DBContext.SaveChanges();
        }

        public void Agregar<TDto>(TDto dto) where TDto : class
        {
            var objeto = this.GetObjeto(dto);
            this.GuardadosAdicionales(this.DBContext, objeto, dto);
            var dbSet = this.DBContext.Set<T>();
            dbSet.Add(objeto);
            this.DBContext.SaveChanges();
        }

        public bool Modificar<TDto>(TDto dto) where TDto : class
        {
            var objeto = this.GetObjetoInDb(dto, this.DBContext);
            objeto = this.BuildObjeto(this.DBContext, dto, objeto);
            this.DBContext.SaveChanges();

            return true;
        }

        private T GetObjeto<TDto>(TDto dto) where TDto : class
        {
            Mapper.CreateMap<TDto, T>();
            return Mapper.Map<T>(dto);
        }

        private T GetObjetoInDb<TDto>(TDto dto, GestionStockContext dbContext) where TDto : class
        {
            var id = this.GetId(dto);
            return this.ObtenerObjeto(id, dbContext);
        }

        private object GetId<TDto>(TDto dto) where TDto : class
        {
            var idIdentificador = new IdIdentificator<T>();
            var idName = idIdentificador.GetIdName();
            var id = typeof(TDto).GetProperty(idName).GetValue(dto);
            return id;
        }

        private T ObtenerObjeto(object id, GestionStockContext dbContext) => dbContext.Set<T>().Find(id);

        public T BuildObjeto<TDto>(GestionStockContext dbContext, TDto dto, T objeto) where TDto : class
        {
            Mapper.CreateMap<TDto, T>();
            Mapper.Map(dto, objeto);

            this.GuardadosAdicionales(dbContext, objeto, dto);
            return objeto;
        }

        protected virtual void GuardadosAdicionales<TDto>(GestionStockContext dbContext, T objeto, TDto dto) where TDto : class
        {
            // hook method
        }
    }
}
