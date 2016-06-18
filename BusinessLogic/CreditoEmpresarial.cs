using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
 public class CreditoEmpresarial
    {


        public int NUMEROCUENTA { get; set; }
        public string CEDULA { get; set; }
        public string BENEFICIO { get; set; }
        public string SEGURO { get; set; }
        public string COBERTURAAUTOS { get; set; }
        public string COBERTURAACCIDENTES { get; set; }
        public DateTime FECHA { get; set; }

        public CreditoEmpresarial() {

        }

        public CreditoEmpresarial(int numerocuenta, string cedula, string beneficio, string seguro, string coberturaautos, string coberturaaccidentes, DateTime time) {
            this.NUMEROCUENTA = numerocuenta;
            this.CEDULA = cedula;
            this.BENEFICIO = beneficio;
            this.SEGURO = seguro;
            this.COBERTURAAUTOS = coberturaautos;
            this.COBERTURAACCIDENTES = coberturaaccidentes;

        }


        public Boolean addCredito(int numerocuenta, string cedula, string beneficio, string seguro, string coberturaautos, string coberturaaccidentes, DateTime fecha)
        {
          return  new DAOcreditoEmpresarial().addCredito(numerocuenta, cedula, beneficio, seguro, coberturaautos, coberturaaccidentes, fecha);
        }

        public Boolean deleteCredito(int numero) {
            return new DAOcreditoEmpresarial().deleteCredito(numero);
        }

        public List<CreditoEmpresarial> getAllCreditoEmpresarial(String filter)
        {
            List<CreditoEmpresarial> list = new List<CreditoEmpresarial>();
            List<TOcreditoEmpresarial> tol = new DAOcreditoEmpresarial().getAllCreditoEmpresarial(filter);
            foreach (TOcreditoEmpresarial item in tol)
            {
                list.Add(new CreditoEmpresarial(item.NUMEROCUENTA, item.CEDULA, item.BENEFICIO, item.SEGURO, item.COBERTURAAUTOS, item.COBERTURAACCIDENTES, item.FECHA));
            }
            return list;

        }

    }



}

