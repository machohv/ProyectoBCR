using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Seguro
    {


        public int CodigoSeguro { get; set; }
        public string Cedula { get; set; }
        public string TipoSeguro { get; set; }
        public string Asegurado { get; set; }
        public double ValorSeguro { get; set; }

        public Entidad Entidad { get; set; }
       

    }
}
