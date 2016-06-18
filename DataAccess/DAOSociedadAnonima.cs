using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAOSociedadAnonima
    {
        public Boolean addSociedadAnonima(String ced,String mail, string password, String cedrep, String nomrep) {
            try
            {
                SqlCommand com = new SqlCommand("[dbo].[AddSociedadAnonima] @Cedula=@ced , @Correo ="+
                    "@mail, @Password=@password, @CedulaRepresentante ="+
                    "@cedrep,@NombreRepresentante = @nomrep", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@ced",ced);
                com.Parameters.AddWithValue("@mail",mail);
                com.Parameters.AddWithValue("@password",password);
                com.Parameters.AddWithValue("@cedrep",cedrep);
                com.Parameters.AddWithValue("@nomrep",nomrep);

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

        public Boolean deleteSociedadAnonima(String ced)
        {
           
            try
            {
                SqlCommand com = new SqlCommand("EXECUTE dbo.deleteSociedadAnonima @cedulajuridica = @ced", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@ced", ced);
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

        public Boolean updateSociedadAnonima(String ced, String mail, String password, String cedrep, String nomrep) {
            try
            {
                SqlCommand com = new SqlCommand("EXECUTE ", DAO_CONNECTION_STRING.getConnectionInstance());
                return true;
            }
            catch (Exception)
            {
                return false;
            }

    

        }



    }
}
