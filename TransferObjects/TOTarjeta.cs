using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOTarjeta
    {
        public int CVV { get; set; }
        public string CasaMatriz { get; set; }
        public string imgSrc { get; set; }
        public string Descripcion { get; set; }
        public string NumeroTarjeta { get; set; }
        public int Pin { get; set; }
        public TOCuenta Cuenta { get; set; }
        public TOEntidad Cliente { get; set; }
    }
}
