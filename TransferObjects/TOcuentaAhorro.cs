using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
   public class TOcuentaAhorro
    {
        public int NUMERO_CUENTA { get; set; }
        public int LIMITE { get; set; }

        public TOcuentaAhorro() { }

        public TOcuentaAhorro(int numero, int limite)
        {
            this.LIMITE = limite;
            this.NUMERO_CUENTA = numero;
        }
    }
}
