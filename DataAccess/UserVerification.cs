using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    
    public class UserVerification
    {
        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
        public bool userVerification(string cedula, string password) {
            SqlCommand command = new SqlCommand("LoginUsuario", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Cedula", cedula);
            command.Parameters.AddWithValue("@Password", password);

            
            SqlParameter sqlParam = new SqlParameter("@Result", DbType.Boolean);
            sqlParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(sqlParam);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return int.Parse(command.Parameters["@Result"].Value.ToString()) == 1 ? true : false;
        }
    }
}
