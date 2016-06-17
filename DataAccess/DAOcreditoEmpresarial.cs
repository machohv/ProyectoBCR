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


        public Boolean addCredito(int numerocuenta, string cedula, string beneficio, string seguro, string coberturaautos, string coberturaaccidentes, DateTime fecha)
       {
            try
            {
                SqlCommand com = new SqlCommand("EXECUTE @numerocuenta = @nocuenta,@cedula = @ced, @beneficio" +
                    " = @ben, @seguro = @seg, @cobertura_autos = @cobertautos, @cobertura_accidentes = @ coberturaaccidentes" +
                    "@fecha_renovacion = @fecha", DAO_CONNECTION_STRING.getConnectionInstance());

                com.Parameters.AddWithValue("@nocuenta", numerocuenta);
                com.Parameters.AddWithValue("@ced", cedula);
                com.Parameters.AddWithValue("@ben", beneficio);
                com.Parameters.AddWithValue("@seg", seguro);
                com.Parameters.AddWithValue("@coberautos", coberturaautos);
                com.Parameters.AddWithValue("@coberturaaccidentes", coberturaaccidentes);
                com.Parameters.AddWithValue("@fecha", fecha);

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

        public Boolean deleteCredito(int numero) {
            SqlCommand com = new SqlCommand("execute [DeleteCreditoEmpresarial] @NumeroCuenta = @numero;", DAO_CONNECTION_STRING.getConnectionInstance());
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

        public List<TOcreditoEmpresarial> getAllCreditoEmpresarial(String filter) {

            SqlCommand com = new SqlCommand("EXECUTE getCuentaCredito @filter = @filt",DAO_CONNECTION_STRING.getConnectionInstance());
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
                    list.Add(new TOcreditoEmpresarial(int.Parse(item[0].ToString()),item[1].ToString(),item[2].ToString(),item[3].ToString(),item[4].ToString(),item[5].ToString(), DateTime.Parse(item[6].ToString())));
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


