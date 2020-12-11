using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBetProject.Models;

namespace PlaceMyBetProject.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<Evento> Get()
        {
            var repo = new EventosRepository();
            List<Evento> eventos = repo.Retrieve();
            return eventos;
        }

        // GET: api/Eventos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Eventos
        public void Post([FromBody]Evento e)
        {
            var repo = new EventosRepository();
            repo.Save(e);
        }

        // PUT: api/Eventos/5
        public void Put(int id, string local, string visitante)
        {
            var repo = new EventosRepository();
            repo.UpdateEventos(id, local, visitante);
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
            var repo = new EventosRepository();
            repo.DeleteEventos(id);
        }
    }
}
