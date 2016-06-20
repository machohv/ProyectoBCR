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
        public string AddPension(string cedula, string tipoPension, string valorPension)
        {
            administradorPension.AddPension(new Pensiones
            {
                Cedula = cedula,
                TipoPension = tipoPension,
                ValorPension = double.Parse(valorPension)
            
            });

            return " Se ha añadido a la pension exitosamente";

        }

        [WebMethod]
        public void getAllPensiones()
        {
            List<Pensiones> pensiones = administradorPension.getPensiones();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(pensiones));
        }

        [WebMethod]
        public void getPension(string codigoPension)
        {
            Pensiones pension = administradorPension.getPension(codigoPension);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(pension));
        }

        [WebMethod]
        public string EditPension(string codigoPension, string cedula, string tipoPension, string valorPension)
        {
            administradorPension.EditPension(new Pensiones
            {
                CodigoPension = int.Parse(codigoPension),
                Cedula = cedula,
                TipoPension = tipoPension,
                ValorPension = double.Parse(valorPension)
            });

            return " Se ha editado a pension exitosamente";

        }

        [WebMethod]
        public string DeletePension(string codigoPension)
        {
            administradorPension.deletePension(codigoPension);

            return " Se ha eliminado la pension exitosamente";

        }

        [WebMethod]
        public string AddSeguro(string cedula, string tipoSeguro, string asegurado, string valorSeguro)
        {
            administradorSeguro.AddSeguro(new Seguro
            {
                Cedula = cedula,
                TipoSeguro = tipoSeguro,
                Asegurado = asegurado,
                ValorSeguro = double.Parse(valorSeguro)

            });

            return " Se ha añadido el seguro exitosamente";

        }

        [WebMethod]
        public void getAllSeguros()
        {
            List<Seguro> seguros = administradorSeguro.getSeguros();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(seguros));
        }

        [WebMethod]
        public void getSeguro(string CodigoSeguro)
        {
            Seguro seguro = administradorSeguro.getSeguro(CodigoSeguro);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(seguro));
        }




        [WebMethod]
        public string EditSeguro(string codigoSeguro, string cedula, string tipoSeguro, string asegurado, string valorSeguro)
        {
            administradorSeguro.EditSeguro(new Seguro
            {
                CodigoSeguro = int.Parse(codigoSeguro),
                Cedula = cedula,
                TipoSeguro = tipoSeguro,
                Asegurado = asegurado,
                ValorSeguro = double.Parse(valorSeguro)
            });

            return " Se ha editado el seguro exitosamente";
        }


        [WebMethod]
        public string DeleteSeguro(string CodigoSeguro)
        {
            administradorSeguro.deleteSeguro(CodigoSeguro);

            return " Se ha eliminado exitosamente";

        }
        [WebMethod]
        public void getSociedadesAnonimas(String id)
        {
            List<SociedadAnonima> list = new SociedadAnonima().getSociedadesAnonimas(id);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(list));
        }

        [WebMethod]
        public void getSociedadAnonima(String id)
        {
            SociedadAnonima l = new SociedadAnonima().getSociedadAnonima(id);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(l));
        }

        [WebMethod]
        public string addSociedadAnonima(string cedula, string correo, string password, string cedularep, string nombrerep)
        {
            new SociedadAnonima().addSociedadAnonima(cedula, correo, password, cedularep, nombrerep);
            return "se agrego exitosamente la empresa identificada por: " + cedula ;

        }

        [WebMethod]
        public string updateSociedadAnonima(string cedula, string correo, string password, string cedularep, string nombrerep)
        {
            new SociedadAnonima().updateSociedad(cedula, correo, password, cedularep, nombrerep);
            return "Se editó exitosamente la empresa identificada por: " + cedula;

    }

        [WebMethod]
        public string addCuentaEmpresarial(string divisa, string taza, string cedula, string tarjeta, string meses)
        {
            int tar = int.Parse(tarjeta);
            int m = int.Parse(meses);
            new CreditoEmpresarial().addCredito(divisa, 32, cedula, tar, m);
            return "Se registro exitosamente a: " + cedula;
        }

        [WebMethod]
        public void getCuentasEmpresariales()
        {
            var cuentaempresarial = new CreditoEmpresarial().getAllCreditoEmpresarial();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(cuentaempresarial));
        }

        [WebMethod]
        public void getCuentaAhorro(string id)
        {
            var cuenta = new CuentaAhorro().getCuenta(id);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(cuenta));
        }

        [WebMethod]
        public String addCuentaAhorro(string id,string divisa,string balance)
        {
            new CuentaAhorro().addCuentaAhorro(id, divisa, balance);
            return "agregada la cuenta identificada por:" + id;
        }

        [WebMethod]
        public void getCuentasAhorro()
        {
            var cuentas = new CuentaAhorro().getCuentas();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(cuentas));
        }
        [WebMethod]
        public String addCuentaCorriente(string id, string divisa, string balance)
        {
            new CuentaCorriente().addCuentaCorriente(id, divisa, balance);
            return "agregada la cuenta identificada por:" + id;
        }
        [WebMethod]
        public void getCuentasCorrientes()
        {
           var cuentas =  new CuentaCorriente().getCuentas();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(cuentas));
        }
    }

}
