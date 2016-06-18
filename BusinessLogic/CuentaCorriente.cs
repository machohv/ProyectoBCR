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

        public int NUMERO_CUENTA { get; set; }
        public Boolean TIENECHEQUES { get; set; }

        public CuentaCorriente() { }

        public CuentaCorriente(int numero, Boolean tienecheques)
        {
            this.TIENECHEQUES = tienecheques;
            this.NUMERO_CUENTA = numero;
        }

        public Boolean addCuentaCorriente(int numero, Boolean cheques)
        {
            return new DAOCuentaCorriente().addCuentaCorriente(numero, cheques);
        }

        public Boolean deleteCuentaCorriente(int numero)
        {
            return new DAOCuentaCorriente().deleteCuentaCorriente(numero);
        }

        public List<CuentaCorriente> getCuenta(int numero)
        {

            List<TOcuentaCorriente> list = new DAOCuentaCorriente().getCuentaCorriente(numero);
            var list2 = new List<CuentaCorriente>();
            foreach (TOcuentaCorriente item in list)
            {
                list2.Add(new CuentaCorriente(item.NUMERO_CUENTA, item.TIENECHEQUES));
            }
            return list2;
        }
    }
}
