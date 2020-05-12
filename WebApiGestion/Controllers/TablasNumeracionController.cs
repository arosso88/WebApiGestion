namespace WebApiGestion.Controllers
{
    using AutoMapper;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Dtos;
    using Microsoft.AspNetCore.Authorization;

    [ApiController]
    [Route("[controller]")]
    public class TablasNumeracionController : ControladorBaseController
    {
        private readonly IServiceTablasNumeracion service;

        public TablasNumeracionController(IServiceTablasNumeracion service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<TablasNumeracionDto> GetTodos()
        {
            this.SetearDBContext(this.service);
            var todos = Mapper.Map<IEnumerable<TablasNumeracionDto>>(this.service.ObtenerTodos());
            this.DisposeDBContext(this.service.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public TablasNumeracionDto GetUno(int id)
        {
            this.SetearDBContext(this.service);
            var uno = Mapper.Map<TablasNumeracionDto>(this.service.ObtenerPorId(id));
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
        public void Modificar(TablasNumeracionDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Modificar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(TablasNumeracionDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Agregar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }
    }
}