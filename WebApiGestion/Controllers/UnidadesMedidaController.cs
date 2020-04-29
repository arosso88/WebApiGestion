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
    }
}