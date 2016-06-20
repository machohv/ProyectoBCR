using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class CuentaAhorro
    {
        public string NUMERO_CUENTA { get; set; }
        public string sinpe { get; set; }
        public string balance { get; set; }
        public string saldobloqueado { get; set; }
        public string saldo_congelado { get; set; }
        public string divisa { get; set; }
        public string cedula { get; set; }

        public CuentaAhorro(string numerocuenta, string sinpe, string balance, string saldobloq, string saldocong, string divisa,string cedu) {
            this.NUMERO_CUENTA = numerocuenta;
            this.sinpe = sinpe;
            this.balance = balance;
            this.saldobloqueado = saldobloq;
            this.saldo_congelado = saldocong;
            this.divisa = divisa;
            this.cedula = cedu;

        }

        public CuentaAhorro() { }


        public Boolean addCuentaAhorro(String ced, string divisa , string balance)
        {
            return new DAOCuentaAhorro().addCuentaAhorro(ced,divisa,balance);
        }

        public Boolean deleteCuentaAhorro(int numero) {
            return new DAOCuentaAhorro().deleteCuentaAhorro(numero);
        }

        public List<CuentaAhorro> getCuenta(string numero) {

            List<TransferObjects.TOcuentaAhorro> list =  new DAOCuentaAhorro().getCuentaAhorro(numero);
            var list2 = new List<CuentaAhorro>();
            foreach (TransferObjects.TOcuentaAhorro item in list)
            {
                list2.Add(new CuentaAhorro(item.NUMERO_CUENTA, item.sinpe, item.balance, item.saldobloqueado, item.saldo_congelado, item.divisa, item.cedula));
            }
            return list2;
        }

        public List<CuentaAhorro> getCuentas()
        {
            List<TransferObjects.TOcuentaAhorro> list = new DAOCuentaAhorro().getCuentasAhorro();
            var list2 = new List<CuentaAhorro>();
            foreach (TransferObjects.TOcuentaAhorro item in list)
            {
                list2.Add(new CuentaAhorro(item.NUMERO_CUENTA,item.sinpe,item.balance,item.saldobloqueado,item.saldo_congelado,item.divisa,item.cedula));
            }
            return list2;
        }



    }
}
