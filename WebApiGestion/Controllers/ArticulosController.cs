namespace WebApiGestion.Controllers
{
    using AutoMapper;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Dtos;
    using Microsoft.AspNetCore.Authorization;

    public class ArticulosController : ControladorBaseController
    {
        private IServiceArticulos serviceArticulos;
        
        public ArticulosController(IServiceArticulos serviceArticulos)
        {
            this.serviceArticulos = serviceArticulos;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<ArticulosDto> GetTodos()
        {
            this.SetearDBContext(this.serviceArticulos);
            var todos = Mapper.Map<IEnumerable<ArticulosDto>>(this.serviceArticulos.ObtenerTodos());
            this.DisposeDBContext(this.serviceArticulos.DBContext);

            return todos;
        }
 
        [HttpGet("{id}")]
        [Authorize]
        public ArticulosDto GetUno(int id)
        {
            this.SetearDBContext(this.serviceArticulos);
            var uno = Mapper.Map<ArticulosDto>(this.serviceArticulos.ObtenerPorId(id));
            this.DisposeDBContext(this.serviceArticulos.DBContext);

            return uno;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public void Eliminar(int id)
        {
            this.SetearDBContext(this.serviceArticulos);
            this.serviceArticulos.Eliminar(id);
            this.DisposeDBContext(this.serviceArticulos.DBContext);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void Modificar(ArticulosDto dto)
        {
            this.SetearDBContext(this.serviceArticulos);
            this.serviceArticulos.Modificar(dto);
            this.DisposeDBContext(this.serviceArticulos.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(ArticulosDto dto)
        {
            this.SetearDBContext(this.serviceArticulos);
            this.serviceArticulos.Agregar(dto);
            this.DisposeDBContext(this.serviceArticulos.DBContext);
        }
    }
}