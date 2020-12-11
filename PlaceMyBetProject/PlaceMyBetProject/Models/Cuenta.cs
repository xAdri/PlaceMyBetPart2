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
    }
}