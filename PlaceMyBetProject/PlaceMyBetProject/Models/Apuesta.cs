using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class Apuesta
    {
        public int apuestaId { get; set; }
        public double tipoMercado { get; set; }
        public double tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dineroApuesta { get; set; }
        public DateTime fecha { get; set; }

        public int eventoId { get; set; }
        public Evento evento { get; set; }
        public int mercadoId { get; set; }
        public Mercado mercado { get; set; }
        public int usuarioId { get; set; }
        public Usuario usuario { get; set; }
    }
}