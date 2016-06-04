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



            new DAOEmpleado().AddEmpleado(new TOEmpleado
            {
                Cedula = "116560680",
                Correo = "jose.hernandez@ucrso.info",
                Password = "StoredProcedure",
                PrimerNombre = "Jose",
                SegundoNombre = "Andres",
                PrimerApellido = "Hernandez",
                SegundoApellido = "Vargas",
                Profesion = "Developer",
                Salario = 1000000
            });

            //TOEmpleado e = new DAOEmpleado().getEmpleado("116560680");
            //if (e == null)
            //{
            //    MessageBox.Show("No es un empleado");
            //}
            //else
            //{
            //    MessageBox.Show(e.PrimerApellido);
            //}

        }
    }
}
