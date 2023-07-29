using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public DataContext Context { get; }

        public EventoController(DataContext context)
        {
            this.Context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Context.Eventos;
        }
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return Context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo PUT: "+id;
        }
    }
}
