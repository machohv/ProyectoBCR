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

        public Boolean addCuentaAhorro(String ced ,string divisa,string balance) {
            try
            {
                SqlCommand com = new SqlCommand("execute addDebito @Cedula="+ced+",@Divisa= "+divisa+",@NumeroCuenta=0,@Balance="+balance+";", DAO_CONNECTION_STRING.getConnectionInstance());
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

        public List<TOcuentaAhorro> getCuentaAhorro(string filter) {
            SqlCommand com = new SqlCommand("select c.numero_cuenta, numero_sinpe,balance,saldo_bloqueado, saldo_congelado, divisa, cedula from cuenta as c join debito as d on c.numero_cuenta = d.numero_cuenta where cedula ="+filter+";", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@filter", filter);
            List<TOcuentaAhorro> list = new List<TOcuentaAhorro>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TOcuentaAhorro(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString()));
            }
            return list;
        }

        public List<TOcuentaAhorro> getCuentasAhorro()
        {
            SqlCommand com = new SqlCommand("select c.numero_cuenta, numero_sinpe,balance,saldo_bloqueado, saldo_congelado, divisa, cedula from cuenta as c join debito as d on c.numero_cuenta = d.numero_cuenta", DAO_CONNECTION_STRING.getConnectionInstance());
          
            List<TOcuentaAhorro> list = new List<TOcuentaAhorro>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TOcuentaAhorro(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString()));
            }
            return list;
        }
    }
}
