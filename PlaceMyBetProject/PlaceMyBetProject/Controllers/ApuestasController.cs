using PlaceMyBetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBetProject.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
        public IEnumerable<Apuesta> Get()
        {
            var repo = new ApuestasRepository();
            List<Apuesta> apuestas = repo.Retrieve();
            return apuestas;
        }

        // GET: api/Apuestas/5
        public Apuesta Get(int id)
        {
            var repo = new ApuestasRepository();
            Apuesta apuesta = repo.RetrieveId(id);
            return apuesta;
        }

        // POST: api/Apuestas
        public void Post([FromBody]Apuesta a)
        {
            var repo = new ApuestasRepository();
            repo.Save(a);
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
