using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
   public class TOcuentaAhorro
    {
        public string NUMERO_CUENTA { get; set; }
        public string sinpe { get; set; }
        public string balance { get; set; }
        public string saldobloqueado { get; set; }
        public string saldo_congelado { get; set; }
        public string divisa { get; set; }
        public string cedula { get; set; }

        public TOcuentaAhorro(string numerocuenta, string sinpe, string balance, string saldobloq, string saldocong, string divisa, string cedu)
        {
            this.NUMERO_CUENTA = numerocuenta;
            this.sinpe = sinpe;
            this.balance = balance;
            this.saldobloqueado = saldobloq;
            this.saldo_congelado = saldocong;
            this.divisa = divisa;
            this.cedula = cedu;

        }
    }
}
