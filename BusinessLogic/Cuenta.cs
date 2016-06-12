using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public string NumeroSinpe { get; set; }
        public double Balance { get; set; }
        public double SaldoBloqueado { get; set; }
        public double SaldoCongelado { get; set; }
        public string Divisa { get; set; }

    }
}
