﻿namespace WebApiGestion.Controllers
{
    using AutoMapper;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Dtos;
    using Microsoft.AspNetCore.Authorization;

    [ApiController]
    [Route("[controller]")]
    public class ComprobantesEmitidosController : ControladorBaseController
    {
        private readonly IServiceComprobantesEmitidos service;

        public ComprobantesEmitidosController(IServiceComprobantesEmitidos service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<ComprobantesEmitidosDto> GetTodos(string emitidoRecibido)
        {
            var filtros = new FiltrosComprobantesEmitidosDto() 
            { 
                EmitidoRecibido = emitidoRecibido 
            };

            this.SetearDBContext(this.service);
            var todos = Mapper.Map<IEnumerable<ComprobantesEmitidosDto>>(this.service.GetTodosFiltrado(filtros));
            this.DisposeDBContext(this.service.DBContext);

            return todos;
        }

        [HttpGet("{id}")]
        [Authorize]
        public ComprobantesEmitidosDto GetUno(int id)
        {
            this.SetearDBContext(this.service);
            var uno = Mapper.Map<ComprobantesEmitidosDto>(this.service.ObtenerPorId(id));
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
        public void Modificar(ComprobantesEmitidosDto dto)
        {
            this.SetearDBContext(this.service);
            this.service.Modificar(dto);
            this.DisposeDBContext(this.service.DBContext);
        }

        [HttpPost]
        [Authorize]
        public void Agregar(ComprobantesEmitidosDto cemDto)
        {
            this.SetearDBContext(this.service);
            this.service.GuardarComprobanteEmitido(cemDto);
            this.DisposeDBContext(this.service.DBContext);
        }
    }
}