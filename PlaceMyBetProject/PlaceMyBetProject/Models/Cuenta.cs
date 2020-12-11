using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class Cuenta
    {
        public string cuentaId { get; set; }
        public string nombreBanco { get; set; }
        public double saldo { get; set; }

        public int usuarioId;
        public Usuario usuario;

        public Cuenta(string cuentaId, string nombreBanco, double saldo, int usuarioId)
        {
            this.cuentaId = cuentaId;
            this.nombreBanco = nombreBanco;
            this.saldo = saldo;
            this.usuarioId = usuarioId;
        }

        public Cuenta()
        {
        }
    }
}