using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class EntidadAdministrator
    {
        private DAOEntidad daoEntidad = new DAOEntidad();

        public Entidad getEntidad(string cedula)
        {
            TOEntidad e = daoEntidad.getEntidad(cedula);
            if (e != null)
            {
                return new Entidad
                {
                    Cedula = e.Cedula,
                    Password = e.Password,
                    Correo = e.Correo
                };
            }
            return null;
        }

        public bool validateUser(string cedula, string password)
        {
            return new UserVerification().verifyPassword(cedula, Encryptor.MD5Hash(password));
        }

        public Entidad getSpecific(string cedula)
        {
            PersonasAdministrator pa = new PersonasAdministrator();

            Persona p = pa.getPersona(cedula);
            if (p != null)
            {
                return p;
            }
            
            return null;
        }
    }
}
