﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public List<TransferObjects.TOSociedadAnonima> getSociedadesAnonimas(String cedula) {
            SqlCommand com = new SqlCommand("EXECUTE getSociedadAnonima @cedula = @ced", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@ced", cedula);
            DataTable dt = new DataTable();
            var list = new List<TransferObjects.TOSociedadAnonima>();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows) 
            {
                list.Add(new TransferObjects.TOSociedadAnonima(item[0].ToString(),item[1].ToString(),item[2].ToString(),item[4].ToString()));
            }
            return list; 
        }

        public List<TransferObjects.TOSociedadAnonima> getSociedadAnonima(String cedula)
        {//item.CEDULA, item.CEDULAREPRESENTANTE, item.NOMBREREPRESENTANTE, item.correo
            SqlCommand com = new SqlCommand("SELECT  s.CEDULA, s.CEDULAREPRESENTANTE, s.NOMBREREPRESENTANTE,entidad.correo  from SOCIEDAD_ANONIMA as s join entidad on entidad.cedula = s.cedula WHERE s.cedula=@ced", DAO_CONNECTION_STRING.getConnectionInstance());
            com.Parameters.AddWithValue("@ced", cedula);
            DataTable dt = new DataTable();
            var list = new List<TransferObjects.TOSociedadAnonima>();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new TransferObjects.TOSociedadAnonima(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString()));
            }
            return list;
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
                SqlCommand com = new SqlCommand("UPDATE SOCIEDAD_ANONIMA SET "+
                    "CEDULAREPRESENTANTE=@cedrep, NOMBREREPRESENTANTE=@nomrep WHERE SOCIEDAD_ANONIMA.CEDULA=@ced "+
                    ";UPDATE ENTIDAD SET CORREO = @mail WHERE ENTIDAD.CEDULA=@ced ", DAO_CONNECTION_STRING.getConnectionInstance());
                com.Parameters.AddWithValue("@ced",ced);
                com.Parameters.AddWithValue("@cedrep", cedrep);
                com.Parameters.AddWithValue("@nomrep", nomrep);
                com.Parameters.AddWithValue("@mail", mail);
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



    }
}
