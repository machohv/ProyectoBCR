using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TransferObjects
{
  public  class TOSociedadAnonima
    {

        public string CEDULA { get; set; }
        public string CEDULAREPRESENTANTE { set; get; }
        public string NOMBREREPRESENTANTE { get; set; }
        public string correo { set; get; }


        public TOSociedadAnonima() { }


        public TOSociedadAnonima(String ced, string cedularep, string nombrerep, string correo)
        {
            this.CEDULA = ced;
            this.CEDULAREPRESENTANTE = cedularep;
            this.NOMBREREPRESENTANTE = nombrerep;
            this.correo = correo;
        }

    }
}
