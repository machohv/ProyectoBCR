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
        public Boolean addCuentaCorriente(string cedula,string divisa,string balance)
        {
            try
            {
                SqlCommand com = new SqlCommand("execute AddCuentaCorriente @cedula=@ced, @divisa=@div, @NumeroCuenta=0, @balance=@bal", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@ced", cedula);
                com.Parameters.AddWithValue("@div", divisa);
                com.Parameters.AddWithValue("@bal", balance);


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
              //  list.Add(new TOcuentaCorriente(int.Parse(item[0].ToString()), Boolean.Parse(item[0].ToString())));
            }
            return list;
        }

        public List<TOcuentaCorriente> getCuentasCorrientes()
        {
            SqlCommand com = new SqlCommand("select c.numero_cuenta, c.numero_sinpe,c.balance,c.saldo_bloqueado,c.divisa, d.cedula,t.codigo_talonario,t.cantidad_de_cheques  from cuenta as c join debito as d on c.numero_cuenta = d.numero_cuenta join persona as p on p.cedula = d.cedula join talonario_cheques as t on t.numero_cuenta = c.numero_cuenta; ", DAO_CONNECTION_STRING.getConnectionInstance());

            List<TOcuentaCorriente> list = new List<TOcuentaCorriente>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TOcuentaCorriente(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString(), item[6].ToString(), item[7].ToString()));
            }
            return list;
        }
    }

}
