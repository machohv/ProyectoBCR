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
        public int NUMERO_CUENTA { get; set; }
        public int LIMITE { get; set; }

        public CuentaAhorro() { }

        public CuentaAhorro(int numero, int limite) {
            this.LIMITE = limite;
            this.NUMERO_CUENTA = numero;
        }

        public Boolean addCuentaAhorro(int numero, int limite)
        {
            return new DAOCuentaAhorro().addCuentaAhorro(numero, limite);
        }

        public Boolean deleteCuentaAhorro(int numero) {
            return new DAOCuentaAhorro().deleteCuentaAhorro(numero);
        }

        public List<CuentaAhorro> getCuenta(int numero) {

            List<TransferObjects.TOcuentaAhorro> list =  new DAOCuentaAhorro().getCuentaAhorro(numero);
            var list2 = new List<CuentaAhorro>();
            foreach (TransferObjects.TOcuentaAhorro item in list)
            {
                list2.Add(new CuentaAhorro(item.NUMERO_CUENTA, item.NUMERO_CUENTA));
            }
            return list2;
        }



        }
}
