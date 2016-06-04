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
        private PersonasAdministrator administrator = new PersonasAdministrator();

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
            administrator.AddPersona(new Persona {
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
            List<Persona> personas = administrator.getPersonas();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(personas));
        }


    }
}
