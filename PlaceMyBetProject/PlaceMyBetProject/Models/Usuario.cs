﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetProject.Models
{
    public class Usuario
    {
        public string usuarioId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public List<Apuesta> apuestas { get; set; }
        public Cuenta cuenta { get; set; }
    }
}