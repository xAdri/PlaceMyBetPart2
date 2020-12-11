using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class EventosRepository
    {
        internal List<Evento> Retrieve()
        {
            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Evento.ToList();
            }
            return eventos;
        }

        internal void Save(Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Evento.Add(e);
            context.SaveChanges();
        }
    }
}