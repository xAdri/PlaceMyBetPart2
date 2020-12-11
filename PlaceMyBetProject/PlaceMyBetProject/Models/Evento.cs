using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class Evento
    {
        // Primary key lleva el nombre de la clase + id
        public int eventoId { get; set; }
        public string local { get; set; }
        public string visitante { get; set; }
        public DateTime fecha { get; set; }

        // relaciones
        public List<Mercado> mercados { get; set; }

        public Evento(int eventoId, string local, string visitante, DateTime fecha)
        {
            this.eventoId = eventoId;
            this.local = local;
            this.visitante = visitante;
            this.fecha = fecha;
        }

        public Evento()
        {
        }
    }
}