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
    public class UnidadesMedidaController : ControladorBaseController
    {
        private IServiceUnidadesMedida serviceUnidadesMedida;

        public UnidadesMedidaController(IServiceUnidadesMedida serviceUnidadesMedida)
        {
            this.serviceUnidadesMedida = serviceUnidadesMedida;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<UnidadesMedidaDto> GetTodos()
        {
            this.SetearDBContext(this.serviceUnidadesMedida);
            var todos = Mapper.Map<IEnumerable<UnidadesMedidaDto>>(this.serviceUnidadesMedida.ObtenerTodos());
            this.DisposeDBContext(this.serviceUnidadesMedida.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public UnidadesMedidaDto GetUno(int id)
        {
            this.SetearDBContext(this.serviceUnidadesMedida);
            var uno = Mapper.Map<UnidadesMedidaDto>(this.serviceUnidadesMedida.ObtenerPorId(id));
            this.DisposeDBContext(this.serviceUnidadesMedida.DBContext);

            return uno;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void Eliminar(int id)
        {
            this.SetearDBContext(this.serviceUnidadesMedida);
            this.serviceUnidadesMedida.Eliminar(id);
            this.DisposeDBContext(this.serviceUnidadesMedida.DBContext);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void Modificar(UnidadesMedidaDto dto)
        {
            this.SetearDBContext(this.serviceUnidadesMedida);
            this.serviceUnidadesMedida.Modificar(dto);
            this.DisposeDBContext(this.serviceUnidadesMedida.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(UnidadesMedidaDto dto)
        {
            this.SetearDBContext(this.serviceUnidadesMedida);
            this.serviceUnidadesMedida.Agregar(dto);
            this.DisposeDBContext(this.serviceUnidadesMedida.DBContext);
        }
    }
}