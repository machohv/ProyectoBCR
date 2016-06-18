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
  public class DAOCuentaCorriente
    {
        public Boolean addCuentaCorriente(int numero, Boolean cheques)
        {
            try
            {
                SqlCommand com = new SqlCommand("execute AddCuentaCorriente @numerocuenta=@num, @cheques= @cheq", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@num", numero);
                com.Parameters.AddWithValue("@cheq", cheques);

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

        public Boolean deleteCuentaCorriente(int numero)
        {
            try
            {
                SqlCommand com = new SqlCommand("execute DeleteCuentaCorriente @numerocuenta = @num", DAO_CONNECTION_STRING.getConnectionInstance());
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
        public List<TOcuentaCorriente> getCuentaCorriente(int filter)
        {
            SqlCommand com = new SqlCommand("execute [getCuentaCorriente] @numerocuenta= @filter", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@filter", filter);
            List<TOcuentaCorriente> list = new List<TOcuentaCorriente>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TOcuentaCorriente(int.Parse(item[0].ToString()), Boolean.Parse(item[0].ToString())));
            }
            return list;
        }
    }

}
