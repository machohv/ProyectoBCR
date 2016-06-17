using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace DataAccess
{
  public class DAOCuentaAhorro
    {

        public Boolean addCuentaAhorro(int numero, int limite) {
            try
            {
                SqlCommand com = new SqlCommand("execute AddCuentaAhorro @numerocuenta = @num, @limite = @lim", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@num", numero);
                com.Parameters.AddWithValue("@lim", limite);

                DAO_CONNECTION_STRING.getConnectionInstance().Open();
                com.ExecuteNonQuery();
                DAO_CONNECTION_STRING.getConnectionInstance().Close();
                return true;


            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean deleteCuentaAhorro(int numero) {
            try
            {
                SqlCommand com = new SqlCommand("execute DeleteCuentaAhorro @numerocuenta = @num", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@num", numero);

                DAO_CONNECTION_STRING.getConnectionInstance().Open();
                com.ExecuteNonQuery();
                DAO_CONNECTION_STRING.getConnectionInstance().Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<TOcuentaAhorro> getCuentaAhorro(int filter) {
            SqlCommand com = new SqlCommand("execute getCuentaAhorro @numerocuenta= @filter", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@filter", filter);
            List<TOcuentaAhorro> list = new List<TOcuentaAhorro>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TOcuentaAhorro(int.Parse(item[0].ToString()), int.Parse(item[0].ToString())));
            }
            return list;
        }
    }
}
