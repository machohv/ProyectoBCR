using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOCuentaCredito : TOCuenta
    {
        public decimal Taza { get; set; }
        public System.DateTime FechaCorte { get; set; }
    }
}
