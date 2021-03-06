﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CuentaCreditoPersonal : CuentaCredito
    {
        public Persona Cliente { get; set; }
        public string Categoria { get; set; }
        public int Millas { get; set; }
        public System.DateTime FechaRenovacion { get; set; }
        public int Plazo { get; set; }
    }
}
