using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogic;
using System.Web.Script.Serialization;

namespace ClientInterface
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private PersonasAdministrator administratorPersonas = new PersonasAdministrator();
        private CuentaCreditoPersonalAdministrator administradorCuentaPersonal = new CuentaCreditoPersonalAdministrator();
        private EntidadAdministrator administradorEntidades = new EntidadAdministrator();
        private PensionesAdministrator administradorPension = new PensionesAdministrator();
        private SeguroAdministrator administradorSeguro = new SeguroAdministrator();

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
            administratorPersonas.AddPersona(new Persona
            {
                Cedula = cedula,
                Password = password,
                Correo = correo,
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Profesion = profesion
            }, new Telefono
            {
                telefono = telefono,
                celular = celular
            }, new Direccion
            {
                provincia = provincia,
                canton = canton,
                distrito = distrito,
                direccionExacta = direccionExacta
            });

            return " Se ha añadido a  " + primerNombre + " " + segundoNombre + " " +
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
        public void getCuentaCreditoPersonal(string NumeroCuenta)
        {
            Tarjeta tarjeta = administradorCuentaPersonal.getCuentaCreditoPersonal(NumeroCuenta);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(tarjeta));
        }


        [WebMethod]
        public string EditCuentaCreditoPersonal(string NumeroCuenta, string Pin, string Cedula,
            string Balance, string SaldoBloqueado, string SaldoCongelado,
            string Taza, string Millas, string FechaCorte, string FechaRenovacion)
        {
            Tarjeta t = administradorCuentaPersonal.getCuentaCreditoPersonal(NumeroCuenta);
            if (t == null)
            {
                return " Ha ocurrido un error inesperado";
            }
            else
            {
                t.Pin = int.Parse(Pin);
                t.Cliente = administratorPersonas.getPersona(Cedula);
                t.Cuenta.Balance = double.Parse(Balance);
                t.Cuenta.SaldoBloqueado = double.Parse(SaldoBloqueado);
                t.Cuenta.SaldoCongelado = double.Parse(SaldoCongelado);
                ((CuentaCreditoPersonal)t.Cuenta).Millas = int.Parse(Millas);
                ((CuentaCreditoPersonal)t.Cuenta).FechaCorte = System.DateTime.Parse(FechaCorte);
                ((CuentaCreditoPersonal)t.Cuenta).FechaRenovacion = System.DateTime.Parse(FechaRenovacion);

                administradorCuentaPersonal.EditCuentaCreditoPersonal(t);
                return " Se ha editado la cuenta exitosamente";
            }
        }


        [WebMethod]
        public void getAllCuentasCreditoPersonal()
        {
            List<Tarjeta> tarjetas = administradorCuentaPersonal.getCuentasCreditoPersonal();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(tarjetas));
        }

        [WebMethod]
        public string DeleteCuentaCreditoPersonal(string NumeroCuenta)
        {
            administradorCuentaPersonal.deleteCuentaCreditoPersona(NumeroCuenta);
            return " Se ha eliminado la cuenta exitosamente";

        }

        [WebMethod]
        public void getClient(string cedula)
        {
            Entidad client = administradorEntidades.getSpecific(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(client));
        }

        [WebMethod]
        public void getCuentasCreditoPersonal(string cedula)
        {
            List<CuentaCreditoPersonal> cuentas = administradorCuentaPersonal.getCuentasCreditoPersonal(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(cuentas));
        }

        [WebMethod]
        public void getTarjetasCredito(string cedula)
        {
            List<Tarjeta> tarjetas = administradorCuentaPersonal.getTarjetas(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(tarjetas));
        }
        [WebMethod]
        public void getCuentasDebitoCorriente(string cedula)
        {
            var cuentas = new CuentaCorriente().getCuentas();
            List<CuentaCorriente> list = new List<CuentaCorriente>();
            foreach (CuentaCorriente item in cuentas)
            {
                if (item.ced.Equals(cedula))
                {
                    list.Add(item);   
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(list));
        }

        [WebMethod]
        public void getCuentasAhorro(string cedula)
        {
            var cuentas = new CuentaAhorro().getCuentas();
            List<CuentaAhorro> list = new List<CuentaAhorro>();
            foreach (CuentaAhorro item in cuentas)
            {
                if (item.cedula.Equals(cedula))
                {
                    list.Add(item);
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(list));
        }

        [WebMethod]
        public void getSeguros(string cedula)
        {
            List<Seguro> seguros = administradorSeguro.getSeguros(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(seguros));
        }

        [WebMethod]
        public void getPensiones(string cedula)
        {
            List<Pensiones> pensiones = administradorPension.getPensiones(cedula);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(pensiones));
        }
    }
}
