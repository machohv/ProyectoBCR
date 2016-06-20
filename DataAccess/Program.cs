using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using TransferObjects;
namespace DataAccess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //bool result = new UserVerification().userVerification("116560680", "StoredProcedure");
            //MessageBox.Show(result + "");



            //new DAOEmpleado().AddEmpleado(new TOEmpleado
            //{
            //    Cedula = "116560680",
            //    Correo = "jose.hernandez@ucrso.info",
            //    Password = "StoredProcedure",
            //    PrimerNombre = "Jose",
            //    SegundoNombre = "Andres",
            //    PrimerApellido = "Hernandez",
            //    SegundoApellido = "Vargas",
            //    Profesion = "Developer",
            //    Salario = 1000000
            //});

            //TOEmpleado e = new DAOEmpleado().getEmpleado("116560680");
            //if (e == null)
            //{
            //    MessageBox.Show("No es un empleado");
            //}
            //else
            //{
            //    MessageBox.Show(e.PrimerApellido);
            //}



            //Pruebas agregar de cuenta credito personal
            //new DAOCuentaCreditoPersonal().addCuentaCreditoPersonal(new TOTarjeta
            //{
            //    imgSrc = "image",
            //    CasaMatriz = "MasterCard",
            //    Descripcion = "bla bla bla",
            //    Cliente = new DAOPersona().getPersona("116560680"),
            //    Cuenta = new TOCuentaCreditoPersonal {
            //        Divisa = "divisa",
            //        Taza = 0.30m,
            //        Plazo=60,
            //        Cliente = new DAOPersona().getPersona("116560680"),
            //        Categoria = "internacional"
            //    }
            //});


            // Console.WriteLine(new DAOSociedadAnonima().addSociedadAnonima("324234234","MOURRAILLE@ME.COM","MAURIPASSWORD","115620847","MAURICIO MOURRAILLE ROJAS"));
            //  new DAOSociedadAnonima().deleteSociedadAnonima("324234234");
        }
    }
}
