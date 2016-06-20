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
    public class DAOSeguro
    {

        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public TOSeguro getSeguro(string CodigoSeguro)
        {
            SqlCommand command = new SqlCommand("getSeguro", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoSeguro", CodigoSeguro);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOSeguro seguro = null;

            if (reader.Read())
            {
                seguro = new TOSeguro
                {
                    CodigoSeguro = int.Parse(reader["CodigoSeguro"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoSeguro = reader["TipoSeguro"].ToString(),
                    Asegurado = reader["Asegurado"].ToString(),
                    ValorSeguro = double.Parse(reader["ValorSeguro"].ToString())
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return seguro;
        }


        public List<TOSeguro> getSeguros()
        {
            SqlCommand command = new SqlCommand("getSeguros", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOSeguro> seguros = new List<TOSeguro>();

            while (reader.Read())
            {
                seguros.Add(new TOSeguro
                {
                    CodigoSeguro = int.Parse(reader["CodigoSeguro"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoSeguro = reader["TipoSeguro"].ToString(),
                    Asegurado = reader["Asegurado"].ToString(),
                    ValorSeguro = double.Parse(reader["ValorSeguro"].ToString())
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return seguros;
        }

        public List<TOSeguro> getSeguros(string cedula)
        {
            SqlCommand command = new SqlCommand("getSeguros", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOSeguro> seguros = new List<TOSeguro>();

            while (reader.Read())
            {
                seguros.Add(new TOSeguro
                {
                    CodigoSeguro = int.Parse(reader["CodigoSeguro"].ToString()),
                    Cedula = reader["Cedula"].ToString(),
                    TipoSeguro = reader["TipoSeguro"].ToString(),
                    Asegurado = reader["Asegurado"].ToString(),
                    ValorSeguro = double.Parse(reader["ValorSeguro"].ToString())
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return seguros;
        }

        public void AddSeguro(TOSeguro e)
        {
            SqlCommand command = new SqlCommand("AddSeguro", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", e.Cedula);
            command.Parameters.AddWithValue("@TipoSeguro", e.TipoSeguro);
            command.Parameters.AddWithValue("@Asegurado", e.Asegurado);
            command.Parameters.AddWithValue("@ValorSeguro", e.ValorSeguro);


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



        public void updateSeguro(TOSeguro s)
        {
            SqlCommand command = new SqlCommand("EditSeguro", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoSeguro", s.CodigoSeguro);
            command.Parameters.AddWithValue("@Cedula", s.Cedula);
            command.Parameters.AddWithValue("@TipoSeguro", s.TipoSeguro);
            command.Parameters.AddWithValue("@Asegurado", s.Asegurado);
            command.Parameters.AddWithValue("@ValorSeguro", s.ValorSeguro);



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


        public void deleteSeguro(string CodigoSeguro)
        {
            SqlCommand command = new SqlCommand("DeleteSeguro", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodigoSeguro", CodigoSeguro);



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