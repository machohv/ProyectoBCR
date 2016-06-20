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
public class DAOcreditoEmpresarial
    { 


        public Boolean addCredito(String divisa, int taza, String cedula, int tarjeta, int meses )
        {
            try
            {
                SqlCommand com = new SqlCommand("EXECUTE AddCreditoEmpresarial @Divisa="+divisa+", @Taza ="+taza+
                    ",@meses= "+meses+ ",@cedula ="+cedula+ ",@tarjeta = "
                    +tarjeta+",@NumeroCuenta = 0", DAO_CONNECTION_STRING.getConnectionInstance());
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

        public Boolean deleteCredito(String numero) {
            SqlCommand com = new SqlCommand("execute [DeleteCreditoEmpresarial] @ced = @numero;", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@numero", numero);
            try
            {
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

        public List<TOcreditoEmpresarial> getCreditoEmpresarial(String filter) {

            SqlCommand com = new SqlCommand("EXECUTE getCuentaCredito @param = @filt",DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@filt", filter);
            List<TOcreditoEmpresarial> list = new List<TOcreditoEmpresarial>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = com;
                adapter.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(new TOcreditoEmpresarial(item[0].ToString(), item[1].ToString(), item[2].ToString(), DateTime.Parse(item[3].ToString()), item[4].ToString(), item[5].ToString(), item[6].ToString()));
                }
                return list;

            }
            catch (Exception)
            {
                return list;

            }

        }

        public List<TOcreditoEmpresarial> getAllCreditoEmpresarial()
        {

            SqlCommand com = new SqlCommand("execute [dbo].[getCuentasCredito]", DAO_CONNECTION_STRING.getConnectionInstance());
           
            List<TOcreditoEmpresarial> list = new List<TOcreditoEmpresarial>();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = com;
                adapter.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(new TOcreditoEmpresarial(item[0].ToString(), item[1].ToString(), item[2].ToString(), DateTime.Parse(item[3].ToString()), item[4].ToString(), item[5].ToString(), item[6].ToString()));
                }
                return list;

            }
            catch (Exception)
            {
                return list;

            }

        }
    }
}


