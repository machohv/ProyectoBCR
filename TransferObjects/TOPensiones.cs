using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOPensiones : TOPersona
    {


        public int CodigoPension { get; set; }
        //public string Cedula { get; set; }
        public string TipoPension { get; set; }
        public double ValorPension { get; set; }

        public TOEntidad Entidad { get; set; }
        public TOPersona Persona { get; set; }

    }
}
