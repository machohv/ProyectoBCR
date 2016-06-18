using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Pensiones
    {
        public int CodigoPension { get; set; }
        public string Cedula { get; set; }
        public string TipoPension { get; set; }
        public double ValorPension { get; set; }

        public Entidad Entidad { get; set; }
        public Persona Persona { get; set; }



    }
}
