namespace WebApiGestion.Controllers
{
    using AutoMapper;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Dtos;
    using Microsoft.AspNetCore.Authorization;

    public class OrdenesVentaController : ControladorBaseController
    {
        private readonly IServiceOrdenesVenta service;

        public OrdenesVentaController(IServiceOrdenesVenta service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<OrdenesVentaDto> GetTodos()
        {
            this.SetearDBContext(this.service);
            var todos = Mapper.Map<IEnumerable<OrdenesVentaDto>>(this.service.ObtenerTodos());
            this.DisposeDBContext(this.service.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public OrdenesVentaDto GetUno(int id)
        {
            this.SetearDBContext(this.service);
            var uno = Mapper.Map<OrdenesVentaDto>(this.service.ObtenerPorId(id));
            this.DisposeDBContext(this.service.DBContext);

            return uno;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void Eliminar(int id)
        {
            this.SetearDBContext(this.service);
            this.service.Eliminar(id);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void Modificar(OrdenesVentaDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Modificar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(OrdenesVentaDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Agregar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }
    }
}
