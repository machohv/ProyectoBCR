using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class EmpleadosAdministrator
    {
        private DAOEmpleado daoEmpleado = new DAOEmpleado();

        public Empleado getEmpleado(string cedula)
        {
            TOEmpleado e = daoEmpleado.getEmpleado(cedula);
            if (e != null)
            {
                return new Empleado {
                    Cedula = e.Cedula,
                    Password = e.Password,
                    Correo = e.Correo,
                    PrimerNombre = e.PrimerNombre,
                    SegundoNombre = e.SegundoNombre,
                    PrimerApellido = e.PrimerApellido,
                    SegundoApellido = e.SegundoApellido,
                    Profesion = e.Profesion,
                    Salario = e.Salario
                };
            }
            return null;
        }
    }
}
