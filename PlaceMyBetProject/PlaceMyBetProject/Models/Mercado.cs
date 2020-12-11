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
        public List<Apuesta> apuestas { get; set; }

        public Mercado(int mercadoId, double overUnder, double dineroOver, double dineroUnder, double cuotaOver, double cuotaUnder, int eventoId)
        {
            this.mercadoId = mercadoId;
            this.overUnder = overUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.eventoId = eventoId;
        }

        public Mercado()
        {
        }
    }

    public class MercadoDTO
    {
        public double overUnder { get; set; }
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }

        public MercadoDTO(double overUnder, double cuotaOver, double cuotaUnder)
        {
            this.overUnder = overUnder;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
        }

        public MercadoDTO()
        {
        }
    }
}