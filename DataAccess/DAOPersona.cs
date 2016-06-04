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
    public class DAOPersona
    {
        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public TOPersona getPersona(string cedula)
        {
            SqlCommand command = new SqlCommand("getPersona", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOPersona persona = null;

            if (reader.Read())
            {
                persona = new TOPersona
                {
                    Cedula = reader["Cedula"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Password = reader["Password"].ToString(),
                    PrimerNombre = reader["PrimerNombre"].ToString(),
                    SegundoNombre = reader["SegundoNombre"].ToString(),
                    PrimerApellido = reader["PrimerApellido"].ToString(),
                    SegundoApellido = reader["SegundoApellido"].ToString(),
                    Profesion = reader["Profesion"].ToString()
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return persona;
        }

        public  List<TOPersona> getPersonas()
        {
            SqlCommand command = new SqlCommand("getPersonas", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOPersona> personas = new List<TOPersona>();

            while (reader.Read())
            {
                personas.Add(new TOPersona
                {
                    Cedula = reader["Cedula"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Password = reader["Password"].ToString(),
                    PrimerNombre = reader["PrimerNombre"].ToString(),
                    SegundoNombre = reader["SegundoNombre"].ToString(),
                    PrimerApellido = reader["PrimerApellido"].ToString(),
                    SegundoApellido = reader["SegundoApellido"].ToString(),
                    Profesion = reader["Profesion"].ToString()
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return personas;
        }

        public void AddPersona(TOPersona p, TODireccion d, TOTelefono t)
        {
            //Comando para agregar persona a la base de datos
            SqlCommand command = new SqlCommand("AddPersona", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", p.Cedula);
            command.Parameters.AddWithValue("@Correo", p.Correo);
            command.Parameters.AddWithValue("@Password", p.Password);
            command.Parameters.AddWithValue("@PrimerNombre", p.PrimerNombre);
            command.Parameters.AddWithValue("@SegundoNombre", p.SegundoNombre);
            command.Parameters.AddWithValue("@PrimerApellido", p.PrimerApellido);
            command.Parameters.AddWithValue("@SegundoApellido", p.SegundoApellido);
            command.Parameters.AddWithValue("@Profesion", p.Profesion);

            //Comando para agregar direccion a la base de datos
            SqlCommand commandDireccion = new SqlCommand("AddDireccion", connection);
            commandDireccion.CommandType = System.Data.CommandType.StoredProcedure;
            commandDireccion.Parameters.AddWithValue("@Cedula", p.Cedula);
            commandDireccion.Parameters.AddWithValue("@Provincia", d.provincia);
            commandDireccion.Parameters.AddWithValue("@Canton", d.canton);
            commandDireccion.Parameters.AddWithValue("@Distrito", d.distrito);
            commandDireccion.Parameters.AddWithValue("@DireccionExacta", d.direccionExacta);

            //Comando para agregar telefono a la base de datos
            SqlCommand commandTelefono = new SqlCommand("AddTelefono", connection);
            commandTelefono.CommandType = System.Data.CommandType.StoredProcedure;
            commandTelefono.Parameters.AddWithValue("@Cedula", p.Cedula);
            commandTelefono.Parameters.AddWithValue("@Numero", t.telefono);
            commandTelefono.Parameters.AddWithValue("@TipoTelefono", "Teléfono a domicilio");

            //Comando para agregar celular a la base de datos
            SqlCommand commandCelular = new SqlCommand("AddTelefono", connection);
            commandCelular.CommandType = System.Data.CommandType.StoredProcedure;
            commandCelular.Parameters.AddWithValue("@Cedula", p.Cedula);
            commandCelular.Parameters.AddWithValue("@Numero", t.celular);
            commandCelular.Parameters.AddWithValue("@TipoTelefono", "Teléfono celular");

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();
            commandDireccion.ExecuteNonQuery();
            commandTelefono.ExecuteNonQuery();
            commandCelular.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
