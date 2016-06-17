using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOcuentaCorriente
    {

        public int NUMERO_CUENTA { get; set; }
        public Boolean TIENECHEQUES { get; set; }

        public TOcuentaCorriente() { }

        public TOcuentaCorriente(int numero, Boolean tienecheques)
        {
            this.TIENECHEQUES = tienecheques;
            this.NUMERO_CUENTA = numero;
        }
    }
}
