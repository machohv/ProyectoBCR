using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class PersonasAdministrator
    {
        private DAOPersona daoPersona = new DAOPersona();
        public Persona getPersona(string cedula)
        {
            TOPersona p = daoPersona.getPersona(cedula);
            if (p != null)
            {
                return new Persona
                {
                    Cedula = p.Cedula,
                    Password = p.Password,
                    Correo = p.Correo,
                    PrimerNombre = p.PrimerNombre,
                    SegundoNombre = p.SegundoNombre,
                    PrimerApellido = p.PrimerApellido,
                    SegundoApellido = p.SegundoApellido,
                    Profesion = p.Profesion
                };
            }
            return null;
        }

        public List<Persona> getPersonas()
        {
            List<Persona> retorno = new List<Persona>();
            List<TOPersona> listTO = daoPersona.getPersonas();
            foreach(TOPersona p in listTO)
            {
                retorno.Add(new Persona
                {
                    Cedula = p.Cedula,
                    Password = p.Password,
                    Correo = p.Correo,
                    PrimerNombre = p.PrimerNombre,
                    SegundoNombre = p.SegundoNombre,
                    PrimerApellido = p.PrimerApellido,
                    SegundoApellido = p.SegundoApellido,
                    Profesion = p.Profesion

                });
            }
            return retorno;
        }

        public void AddPersona(Persona p, Telefono t, Direccion d)
        {
            p.Password = Encryptor.MD5Hash(p.Password);
            daoPersona.AddPersona(new TOPersona {
                Cedula = p.Cedula,
                Password = p.Password,
                Correo = p.Correo,
                PrimerNombre = p.PrimerNombre,
                SegundoNombre = p.SegundoNombre,
                PrimerApellido = p.PrimerApellido,
                SegundoApellido = p.SegundoApellido,
                Profesion = p.Profesion
            }, new TODireccion {
                provincia = d.provincia,
                canton = d.canton,
                distrito = d.distrito,
                direccionExacta = d.direccionExacta
            }, new TOTelefono {
                telefono = t.telefono,
                celular = t.celular
            });
        }

        public void EditPersona(Persona p)
        {
            p.Password = Encryptor.MD5Hash(p.Password);
            daoPersona.updatePersonas(convertToTOPersona(p));
        }

        public void deletePersona(string cedula)
        {
            daoPersona.deletePersona(cedula);
        }

        public TOPersona convertToTOPersona(Persona p)
        {
            return new TOPersona
            {
                Cedula = p.Cedula,
                Password = p.Password,
                Correo = p.Correo,
                PrimerNombre = p.PrimerNombre,
                SegundoNombre = p.SegundoNombre,
                PrimerApellido = p.PrimerApellido,
                SegundoApellido = p.SegundoApellido,
                Profesion = p.Profesion
            };
        }
        public Persona convertToPersona(TOPersona p)
        {
            return new Persona
            {
                Cedula = p.Cedula,
                Password = p.Password,
                Correo = p.Correo,
                PrimerNombre = p.PrimerNombre,
                SegundoNombre = p.SegundoNombre,
                PrimerApellido = p.PrimerApellido,
                SegundoApellido = p.SegundoApellido,
                Profesion = p.Profesion
            };
        }
    }
}
