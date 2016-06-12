using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;


namespace DataAccess
{
    public class DAOCuentaCreditoPersonal
    {
        private SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);

        public void addTarjeta(TOTarjeta t)
        {
            //Comando para agregar persona a la base de datos
            SqlCommand command = new SqlCommand("AddTarjetaCredito", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CasaMatriz", t.CasaMatriz);
            command.Parameters.AddWithValue("@Image", t.imgSrc);
            command.Parameters.AddWithValue("@Descripcion", t.Descripcion);
            command.Parameters.AddWithValue("@NumeroCuenta", t.Cuenta.NumeroCuenta);
            command.Parameters.AddWithValue("@NombrePortador", 
                ((TOPersona)t.Cliente).PrimerNombre + " "  +
                ((TOPersona)t.Cliente).SegundoNombre + " " +
                ((TOPersona)t.Cliente).PrimerApellido + " " +
                ((TOPersona)t.Cliente).SegundoApellido);
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
        public void addCuentaCreditoPersonal(TOTarjeta t)
        {
            //Comando para agregar persona a la base de datos
            SqlCommand command = new SqlCommand("AddCreditoPersonal", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Divisa", t.Cuenta.Divisa);
            command.Parameters.AddWithValue("@Taza", ((TOCuentaCredito)t.Cuenta).Taza);
            command.Parameters.AddWithValue("@meses", ((TOCuentaCreditoPersonal)t.Cuenta).Plazo);
            command.Parameters.AddWithValue("@Cedula", t.Cliente.Cedula);
            command.Parameters.AddWithValue("@Categoria", ((TOCuentaCreditoPersonal)t.Cuenta).Categoria);

            SqlParameter sqlParam = new SqlParameter("@NumeroCuenta", DbType.Int32);
            sqlParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(sqlParam);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            t.Cuenta.NumeroCuenta = command.Parameters["@NumeroCuenta"].Value.ToString();
            addTarjeta(t);
        }

        public List<TOTarjeta> getCuentasCreditoPersonal()
        {
            SqlCommand command = new SqlCommand("getCreditosPersonales", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOTarjeta> tarjetas = new List<TOTarjeta>();

            while (reader.Read())
            {
                tarjetas.Add(new TOTarjeta
                {
                    NumeroTarjeta = reader["NUMERO_TARJETA"].ToString(),
                    CasaMatriz = reader["CASA_MATRIZ"].ToString(),
                    CVV = int.Parse(reader["CVV"].ToString()),
                    imgSrc = reader["IMAGEN"].ToString(),
                    Descripcion = reader["DESCRIPCION"].ToString(),
                    Pin = int.Parse(reader["PIN"].ToString()),
                    Cliente = new DAOPersona().getPersona(reader["CEDULA"].ToString()),
                    Cuenta = new TOCuentaCreditoPersonal
                    {
                        Balance = double.Parse(reader["BALANCE"].ToString()),
                        SaldoBloqueado = double.Parse(reader["SALDO_BLOQUEADO"].ToString()),
                        SaldoCongelado = double.Parse(reader["SALDO_CONGELADO"].ToString()),
                        Divisa = reader["DIVISA"].ToString(),
                        Taza = decimal.Parse(reader["TAZA"].ToString()),
                        Millas = int.Parse(reader["MILLAS"].ToString()),
                        Categoria = reader["CATEGORIA"].ToString(),
                        FechaCorte = System.DateTime.Parse(reader["FECHA_DE_CORTE"].ToString()),
                        FechaRenovacion = System.DateTime.Parse(reader["FECHA_RENOVACION"].ToString()),
                        NumeroSinpe = reader["NUMERO_SINPE"].ToString(),
                        NumeroCuenta = reader["NUMERO_CUENTA"].ToString(),
                        Cliente = new DAOPersona().getPersona(reader["CEDULA"].ToString())
                    }
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return tarjetas;
        }

        public TOCuentaCreditoPersonal getCuentaCreditoPersonal(string numeroCuenta)
        {
            SqlCommand command = new SqlCommand("getCuentaCreditoPersonal", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOCuentaCreditoPersonal cuenta = null;

            if (reader.Read())
            {
                cuenta = new TOCuentaCreditoPersonal
                {
                    NumeroCuenta = reader["Numero_Cuenta"].ToString(),
                    NumeroSinpe = reader["Numero_Sinpe"].ToString(),
                    Balance = double.Parse(reader["Balance"].ToString()),
                    SaldoBloqueado = double.Parse(reader["Saldo_Bloqueado"].ToString()),
                    SaldoCongelado = double.Parse(reader["Saldo_Congelado"].ToString()),
                    Divisa = reader["Divisa"].ToString(),
                    Taza = decimal.Parse(reader["Taza"].ToString()),
                    FechaCorte = System.DateTime.Parse(reader["Fecha_De_Corte"].ToString()),
                    Cliente = new DAOPersona().getPersona(reader["Cedula"].ToString()),
                    FechaRenovacion = System.DateTime.Parse(reader["Fecha_Renovacion"].ToString()),
                    Millas = int.Parse(reader["Millas"].ToString()),
                    Categoria = reader["Categoria"].ToString()
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return cuenta;
        }
    }
}
