using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SociedadAnonima : Entidad
    {

      
        public string CEDULAREPRESENTANTE { set; get; }
        public string NOMBREREPRESENTANTE { get; set; }
     




        public SociedadAnonima() { }


        public SociedadAnonima(String ced, string cedularep, string nombrerep, string correo)
        {
       
            this.Correo = correo;
            this.Cedula = ced;
            this.CEDULAREPRESENTANTE = cedularep;
            this.NOMBREREPRESENTANTE = nombrerep;
        }

        public List<SociedadAnonima> getSociedadesAnonimas(string id) {
            List<TransferObjects.TOSociedadAnonima> list = new DAOSociedadAnonima().getSociedadesAnonimas(id);
            List<SociedadAnonima> list2 = new List<SociedadAnonima>();
            foreach (TransferObjects.TOSociedadAnonima item in list)
            {
                list2.Add(new SociedadAnonima(item.CEDULA, item.CEDULAREPRESENTANTE, item.NOMBREREPRESENTANTE, item.correo));
            }

            return list2;
        }

        public Boolean addSociedadAnonima(String ced, String mail, string password, String cedrep, String nomrep)
        {
            return new DAOSociedadAnonima().addSociedadAnonima(ced, mail, password, cedrep, nomrep);
        }

        public Boolean deleteSociedadAnonima(String ced) {
            return new DAOSociedadAnonima().deleteSociedadAnonima(ced);
        }


        public Boolean updateSociedad(String ced, String mail, String password, String cedrep, String nomrep) {
            return new DAOSociedadAnonima().updateSociedadAnonima(ced, mail, password, cedrep, nomrep);
        }





    }
}
