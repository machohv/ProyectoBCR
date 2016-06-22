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
    public class DAOPensiones 
    {

        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public TOPensiones getPension(string CodigoPension)
        {
            SqlCommand command = new SqlCommand("getPension", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoPension", CodigoPension);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOPensiones pension = null;

            if (reader.Read())
            {
                pension = new TOPensiones
                {
                    CodigoPension = int.Parse(reader["CodigoPension"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoPension = reader["TipoPension"].ToString(),                    
                    ValorPension = double.Parse(reader["ValorPension"].ToString())                    
                 };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return pension;
        }


        public List<TOPensiones> getPensiones()
        {
            SqlCommand command = new SqlCommand("getPensiones", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOPensiones> pensiones = new List<TOPensiones>();

            while (reader.Read())
            {
                pensiones.Add(new TOPensiones
                {
                    CodigoPension = int.Parse(reader["CodigoPension"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoPension = reader["TipoPension"].ToString(),
                    ValorPension = double.Parse(reader["ValorPension"].ToString())
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return pensiones;
        }

        public List<TOPensiones> getPensiones(string cedula)
        {
            SqlCommand command = new SqlCommand("getPensionesCliente", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOPensiones> pensiones = new List<TOPensiones>();

            while (reader.Read())
            {
                pensiones.Add(new TOPensiones
                {
                    CodigoPension = int.Parse(reader["CodigoPension"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoPension = reader["TipoPension"].ToString(),
                    ValorPension = double.Parse(reader["ValorPension"].ToString())
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return pensiones;
        }

        public void AddPension(TOPensiones e)
        {
            SqlCommand command = new SqlCommand("AddPension", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", e.Cedula);
            command.Parameters.AddWithValue("@TipoPension", e.TipoPension);           
            command.Parameters.AddWithValue("@ValorPension", e.ValorPension);


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



        public void updatePension(TOPensiones p)
        {
            SqlCommand command = new SqlCommand("EditPension", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoPension", p.CodigoPension);
            command.Parameters.AddWithValue("@Cedula", p.Cedula);
            command.Parameters.AddWithValue("@TipoPension", p.TipoPension);
            command.Parameters.AddWithValue("@ValorPension", p.ValorPension);



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


        public void deletePension(string CodigoPension)
        {
            SqlCommand command = new SqlCommand("DeletePension", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoPension", CodigoPension);



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
