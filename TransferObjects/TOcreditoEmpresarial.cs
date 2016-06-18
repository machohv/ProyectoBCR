using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransferObjects
{
    public class TOcreditoEmpresarial
    {

        public int NUMEROCUENTA { get; set; }
        public string CEDULA { get; set; }
        public string BENEFICIO { get; set; }
        public string SEGURO { get; set; }
        public string COBERTURAAUTOS { get; set; }
        public string COBERTURAACCIDENTES { get; set; }
        public DateTime FECHA { get; set; }

        public TOcreditoEmpresarial()
        {

        }

        public TOcreditoEmpresarial(int numerocuenta, string cedula, string beneficio, string seguro, string coberturaautos, string coberturaaccidentes, DateTime time)
        {
            this.NUMEROCUENTA = numerocuenta;
            this.CEDULA = cedula;
            this.BENEFICIO = beneficio;
            this.SEGURO = seguro;
            this.COBERTURAAUTOS = coberturaautos;
            this.COBERTURAACCIDENTES = coberturaaccidentes;

        }


    }
}
