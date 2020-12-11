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

        internal void UpdateEventos(int id, string local, string visitante)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Evento.FirstOrDefault(a => a.eventoId == id);
            evento.local = local;
            evento.visitante = visitante;
            context.SaveChanges();
        }

        internal void DeleteEventos(int id)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Evento.FirstOrDefault(a => a.eventoId == id);
            context.Remove(evento);
            context.SaveChanges();
        }
    }
}