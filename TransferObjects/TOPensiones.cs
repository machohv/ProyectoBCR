using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOPensiones
    {


        public int CodigoPension { get; set; }
        public string Cedula { get; set; }
        public string TipoPension { get; set; }
        public double ValorPEnsion { get; set; }

        public TOEntidad Entidad { get; set; }
        public TOPersona Persona { get; set; }

    }
}
