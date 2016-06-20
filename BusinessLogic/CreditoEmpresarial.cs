using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
 public class CreditoEmpresarial:CuentaCredito
    {

        public string CEDULA { get; set; }
        public string BENEFICIO { get; set; }
        public string SEGURO { get; set; }
        public string COBERTURAAUTOS { get; set; }
        public string NombrePropietario { get; set; }
        public DateTime FECHA { get; set; }
        public int TAZA { get; set; }

        public CreditoEmpresarial() {

        }

        public CreditoEmpresarial (String numerocuenta, string sinpe, string divisa, DateTime renovacion, string seguro, string cedula, String nombrepropietario)
        {
            this.NumeroCuenta = numerocuenta;
            this.NumeroSinpe = sinpe;
            this.Divisa = divisa;
            this.FECHA = renovacion;
            this.SEGURO = seguro;
            this.CEDULA = cedula;
            this.NombrePropietario = nombrepropietario;

   
        }


        public Boolean addCredito(String divisa, int taza, String cedula, int tarjeta, int meses)
        {
          return  new DAOcreditoEmpresarial().addCredito( divisa,  taza,  cedula,  tarjeta,  meses);
        }

        public Boolean deleteCredito(String numero) {
            return new DAOcreditoEmpresarial().deleteCredito(numero);
        }


        public List<CreditoEmpresarial> getCreditoEmpresarial(String filter)
        {
            List<CreditoEmpresarial> list = new List<CreditoEmpresarial>();
            List<TOcreditoEmpresarial> tol = new DAOcreditoEmpresarial().getCreditoEmpresarial(filter);
            foreach (TOcreditoEmpresarial item in tol)
            {
                list.Add(new CreditoEmpresarial(item.NumeroCuenta, item.NumeroSinpe,item.Divisa, item.FECHA,item.SEGURO,item.CEDULA, item.NombrePropietario));
            }
            return list;
        }

        public List<CreditoEmpresarial> getAllCreditoEmpresarial()
        {
            List<CreditoEmpresarial> list = new List<CreditoEmpresarial>();
            List<TOcreditoEmpresarial> tol = new DAOcreditoEmpresarial().getAllCreditoEmpresarial();
            foreach (TOcreditoEmpresarial item in tol)
            {
                list.Add(new CreditoEmpresarial(item.NumeroCuenta, item.NumeroSinpe, item.Divisa, item.FECHA, item.SEGURO, item.CEDULA, item.NombrePropietario));
            }
            return list;
        }

    }



}

