using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class ApuestasRepository
    {
        internal List<Apuesta> Retrieve()
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuesta.ToList();
            }
            return apuestas;
        }

        internal Apuesta RetrieveId(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Apuesta apuesta = context.Apuesta.FirstOrDefault(a => a.apuestaId == id);
                return apuesta;
            }
        }
    }
}