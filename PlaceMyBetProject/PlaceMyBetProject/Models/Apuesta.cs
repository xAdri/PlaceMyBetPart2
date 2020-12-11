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
        public string tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dineroApuesta { get; set; }
        public DateTime fecha { get; set; }

        public int eventoId { get; set; }
        public Evento evento { get; set; }
        public int mercadoId { get; set; }
        public Mercado mercado { get; set; }
        public string usuarioId { get; set; }
        public Usuario usuario { get; set; }

        public Apuesta(int apuestaId, double tipoMercado, string tipoApuesta, double cuota, double dineroApuesta, DateTime fecha, int eventoId, int mercadoId, string usuarioId)
        {
            this.apuestaId = apuestaId;
            this.tipoMercado = tipoMercado;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dineroApuesta = dineroApuesta;
            this.fecha = fecha;
            this.eventoId = eventoId;
            this.mercadoId = mercadoId;
            this.usuarioId = usuarioId;
        }

        public Apuesta()
        {
        }
    }
}