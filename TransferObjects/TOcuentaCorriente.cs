using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class TOcuentaCorriente
    {

        public string NUMERO_CUENTA { get; set; }
        public string sinpe { get; set; }
        public string balance { get; set; }
        public string saldobloq { get; set; }
        public string divisa { get; set; }
        public string ced { get; set; }
        public string codtalonario { get; set; }
        public string numerocheques { get; set; }



        public TOcuentaCorriente(string numerocuenta, string sinpe, string balance, string saldobloq, string divisa, string ced, string codtalonario, string numerocheques)
        {
            this.NUMERO_CUENTA = numerocuenta;
            this.sinpe = sinpe;
            this.balance = balance;
            this.saldobloq = saldobloq;
            this.divisa = divisa;
            this.ced = ced;
            this.codtalonario = codtalonario;
            this.numerocheques = numerocheques;
        }



    }
}
