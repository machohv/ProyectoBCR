using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
   public class CuentaCorriente
    {

        public string NUMERO_CUENTA { get; set; }
        public string sinpe { get; set; }
        public string balance { get; set; }
        public string saldobloq { get; set; }
        public string divisa { get; set; }
        public string ced { get; set; }
        public string codtalonario { get; set; }
        public string numerocheques { get; set; }



        public CuentaCorriente(string numerocuenta, string sinpe, string balance, string saldobloq, string divisa, string ced, string codtalonario, string numerocheques) {
            this.NUMERO_CUENTA = numerocuenta;
            this.sinpe = sinpe;
            this.balance = balance;
            this.saldobloq = saldobloq;
            this.divisa = divisa;
            this.ced = ced;
            this.codtalonario = codtalonario;
            this.numerocheques = numerocheques;
        }






        public CuentaCorriente() { }


        public Boolean addCuentaCorriente(String cedula, string divisa, string balance)
        {
            return new DAOCuentaCorriente().addCuentaCorriente(cedula, divisa,balance);
        }

        public Boolean deleteCuentaCorriente(int numero)
        {
            return new DAOCuentaCorriente().deleteCuentaCorriente(numero);
        }

        public List<CuentaCorriente> getCuentas()
        {

            List<TOcuentaCorriente> list = new DAOCuentaCorriente().getCuentasCorrientes();
            var list2 = new List<CuentaCorriente>();
            foreach (TOcuentaCorriente item in list)
            {
                list2.Add(new CuentaCorriente(item.NUMERO_CUENTA,item.sinpe,item.balance,item.saldobloq,item.divisa,item.ced,item.codtalonario,item.numerocheques));
            }
            return list2;
        }
    }
}
