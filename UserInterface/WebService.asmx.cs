using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using BusinessLogic;
using System.Web.Script.Serialization;

namespace UserInterface
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private PersonasAdministrator administratorPersonas = new PersonasAdministrator();
        private CuentaCreditoPersonalAdministrator administradorCuentaPersonal = new CuentaCreditoPersonalAdministrator();

        [WebMethod]
        public string HelloWorld(string firstName)
        {
            return "Hello " + firstName;
        }

        [WebMethod]
        public string AddPersona(string cedula, string correo, string password, 
            string primerNombre, string segundoNombre, string primerApellido,
            string segundoApellido, string profesion, string telefono, string celular,
            string provincia, string canton, string distrito, string direccionExacta)
        {
            administratorPersonas.AddPersona(new Persona {
                Cedula = cedula,
                Password = password,
                Correo = correo,
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Profesion = profesion
            }, new Telefono {
                telefono = telefono,
                celular = celular
            }, new Direccion {
                provincia = provincia,
                canton = canton,
                distrito = distrito,
                direccionExacta = direccionExacta
            });

            return " Se ha añadido a  " + primerNombre + " " +  segundoNombre + " " +
                primerApellido + " " + segundoApellido + " exitosamente";

        }

        [WebMethod]
        public void getAllPersonas()
        {
            List<Persona> personas = administratorPersonas.getPersonas();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(personas));
        }

        [WebMethod]
        public void getPersona(string cedula)
        {
            Persona persona = administratorPersonas.getPersona(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(persona));
        }


        [WebMethod]
        public string EditPersona(string cedula, string correo, string password,
            string primerNombre, string segundoNombre, string primerApellido,
            string segundoApellido, string profesion)
        {
            administratorPersonas.EditPersona(new Persona
            {
                Cedula = cedula,
                Password = password,
                Correo = correo,
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Profesion = profesion
            });

            return " Se ha editado a " + primerNombre + " " + segundoNombre + " " +
                primerApellido + " " + segundoApellido + " exitosamente";

        }

        [WebMethod]
        public string DeletePersona(string cedula)
        {
            administratorPersonas.deletePersona(cedula);

            return " Se ha eliminado al cliente exitosamente";

        }

        [WebMethod]
        public string AddCuentaCreditoPersonal(string Cedula, string CasaMatriz, string Image,
            string Descripcion, string NombrePortador, string Divisa,
            string Tasa, string Plazo, string Categoria)
        {
            administradorCuentaPersonal.AddCuentaCreditoPersonal(new Tarjeta
            {
                CasaMatriz = CasaMatriz,
                imgSrc = Image,
                Descripcion = Descripcion,
                Cuenta = new CuentaCreditoPersonal
                {
                    Divisa = Divisa,
                    Taza = decimal.Parse(Tasa),
                    Plazo = int.Parse(Plazo),
                    Categoria = Categoria
                },
                Cliente = administratorPersonas.getPersona(Cedula)
            });
            return " Se ha agregador el servicio exitosamente";

        }
        
        [WebMethod]
        public void getAllCuentasCreditoPersonal()
        {
            List<Tarjeta> tarjetas = administradorCuentaPersonal.getCuentasCreditoPersonal();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(tarjetas));
        }
    }
}
