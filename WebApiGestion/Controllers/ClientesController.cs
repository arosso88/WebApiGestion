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
    public class ClientesController : ControladorBaseController
    {
        private readonly IServiceClientes service;

        public ClientesController(IServiceClientes service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<ClientesDto> GetTodos()
        {
            this.SetearDBContext(this.service);
            var todos = Mapper.Map<IEnumerable<ClientesDto>>(this.service.ObtenerTodos());
            this.DisposeDBContext(this.service.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public ClientesDto GetUno(int id)
        {
            this.SetearDBContext(this.service);
            var uno = Mapper.Map<ClientesDto>(this.service.ObtenerPorId(id));
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
        public void Modificar(ClientesDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Modificar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(ClientesDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Agregar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }
    }
}