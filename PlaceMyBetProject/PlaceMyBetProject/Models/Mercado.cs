using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class Mercado
    {
        public int mercadoId { get; set; }
        public double overUnder { get; set; } 
        public double dineroOver { get; set; } 
        public double dineroUnder { get; set; }
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }

        // relacion de un mercado con muchos eventos
        public int eventoId { get; set; }
        public Evento evento { get; set; }
        public int apuestaId { get; set; }
        public List<Apuesta> apuestas { get; set; }
    }
}