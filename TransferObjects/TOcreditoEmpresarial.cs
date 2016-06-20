using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransferObjects
{
    public class TOcreditoEmpresarial : TOCuentaCredito
    {

        public int NUMEROCUENTA { get; set; }
        public string CEDULA { get; set; }
        public string BENEFICIO { get; set; }
        public string SEGURO { get; set; }
        public string COBERTURAAUTOS { get; set; }
        public string NombrePropietario { get; set; }
        public DateTime FECHA { get; set; }

        public TOcreditoEmpresarial()
        {

        }

        public TOcreditoEmpresarial(String numerocuenta, string sinpe, string divisa, DateTime renovacion, string seguro, string cedula, String nombrepropietario)
        {
            this.NumeroCuenta = numerocuenta;
            this.NumeroSinpe = sinpe;
            this.Divisa = divisa;
            this.FECHA = renovacion;
            this.SEGURO = seguro;
            this.CEDULA = cedula;
            this.NombrePropietario = nombrepropietario;

        }


    }
}
