namespace WebApiGestion.Controllers
{
    using AutoMapper;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Dtos;
    using Microsoft.AspNetCore.Authorization;

    public class ProductosController : ControladorBaseController
    {
        private readonly IServiceProductos service;

        public ProductosController(IServiceProductos service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<ProductosDto> GetTodos()
        {
            this.SetearDBContext(this.service);
            var todos = Mapper.Map<IEnumerable<ProductosDto>>(this.service.ObtenerTodos());
            this.DisposeDBContext(this.service.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public ProductosDto GetUno(int id)
        {
            this.SetearDBContext(this.service);
            var uno = Mapper.Map<ProductosDto>(this.service.ObtenerPorId(id));
            this.DisposeDBContext(this.service.DBContext);

            return uno;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void Eliminar(string id)
        {
            this.SetearDBContext(this.service);
            this.service.Eliminar(id);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void Modificar(ProductosDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Modificar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(ProductosDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Agregar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }
    }
}
