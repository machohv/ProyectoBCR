using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DAOEmpleado
    {
        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public TOEmpleado getEmpleado(string cedula)
        {
            SqlCommand command = new SqlCommand("getEmpleado", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOEmpleado empleado = null;

            if (reader.Read())
            {
                empleado = new TOEmpleado
                {
                    Cedula = reader["Cedula"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Password = reader["Password"].ToString(),
                    PrimerNombre = reader["PrimerNombre"].ToString(),
                    SegundoNombre = reader["SegundoNombre"].ToString(),
                    PrimerApellido = reader["PrimerApellido"].ToString(),
                    SegundoApellido = reader["SegundoApellido"].ToString(),
                    Profesion = reader["Profesion"].ToString(),
                    Salario = double.Parse(reader["Salario"].ToString()),
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return empleado;
        }

        public void AddEmpleado(TOEmpleado e)
        {
            SqlCommand command = new SqlCommand("AddEmpleado", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", e.Cedula);
            command.Parameters.AddWithValue("@Correo", e.Correo);
            command.Parameters.AddWithValue("@Password", e.Password);
            command.Parameters.AddWithValue("@PrimerNombre", e.PrimerNombre);
            command.Parameters.AddWithValue("@SegundoNombre", e.SegundoNombre);
            command.Parameters.AddWithValue("@PrimerApellido", e.PrimerApellido);
            command.Parameters.AddWithValue("@SegundoApellido", e.SegundoApellido);
            command.Parameters.AddWithValue("@Profesion", e.Profesion);
            command.Parameters.AddWithValue("@Salario", e.Salario);


            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        
    }
}
