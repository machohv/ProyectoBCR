using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAOEntidad
    {
        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public TOEntidad getEntidad(string cedula)
        {
            SqlCommand command = new SqlCommand("getEntidad", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOEntidad entidad = null;

            if (reader.Read())
            {
                entidad = new TOEntidad
                {
                    Cedula = reader["Cedula"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    Password = reader["Password"].ToString()
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return entidad;
        }

    }
}
