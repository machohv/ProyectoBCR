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

        public TOTarjeta getCuentaCreditoPersonal(string numeroCuenta)
        {
            SqlCommand command = new SqlCommand("getCreditoPersonal", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            TOTarjeta retorno = null;

            if (reader.Read())
            {
                retorno = new TOTarjeta
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
                };
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return retorno;
        }

        public void deleteCuentaCreditoPersonal(string numeroCuenta)
        {
            SqlCommand command = new SqlCommand("DeleteTarjeta", connection);
            SqlCommand command2 = new SqlCommand("DeleteCreditoPersonal", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command2.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
            command2.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);


            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void editCuentaCreditoPersonal(TOTarjeta t)
        {
            SqlCommand command = new SqlCommand("EditTarjeta", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@NumeroTarjeta", t.NumeroTarjeta);
            command.Parameters.AddWithValue("@CasaMatriz", t.CasaMatriz);
            command.Parameters.AddWithValue("@FechaVencimiento", ((TOCuentaCreditoPersonal)t.Cuenta).FechaRenovacion);
            command.Parameters.AddWithValue("@Imagen", t.imgSrc);
            command.Parameters.AddWithValue("@Descripcion", t.Descripcion);
            command.Parameters.AddWithValue("@CVV", t.CVV);
            command.Parameters.AddWithValue("@Pin", t.Pin);
            command.Parameters.AddWithValue("@NombrePortador", 
                ((TOPersona)t.Cliente).PrimerNombre + " "  +
                ((TOPersona)t.Cliente).SegundoNombre + " " +
                ((TOPersona)t.Cliente).PrimerApellido + " " +
                ((TOPersona)t.Cliente).SegundoApellido);


            SqlCommand command2 = new SqlCommand("EditCreditoPersonal", connection);
            command2.CommandType = System.Data.CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@NumeroCuenta", t.Cuenta.NumeroCuenta);
            command2.Parameters.AddWithValue("@NumeroSinpe", t.Cuenta.NumeroSinpe);
            command2.Parameters.AddWithValue("@Divisa", t.Cuenta.Divisa);
            command2.Parameters.AddWithValue("@Balance", t.Cuenta.Balance);
            command2.Parameters.AddWithValue("@SaldoBloqueado", t.Cuenta.SaldoBloqueado);
            command2.Parameters.AddWithValue("@SaldoCongelado", t.Cuenta.SaldoCongelado);
            command2.Parameters.AddWithValue("@Taza", ((TOCuentaCredito)t.Cuenta).Taza);
            command2.Parameters.AddWithValue("@FechaCorte", ((TOCuentaCreditoPersonal)t.Cuenta).FechaCorte);
            command2.Parameters.AddWithValue("@Cedula", t.Cliente.Cedula);
            command2.Parameters.AddWithValue("@Categoria", ((TOCuentaCreditoPersonal)t.Cuenta).Categoria);
            command2.Parameters.AddWithValue("@Millas", ((TOCuentaCreditoPersonal)t.Cuenta).Millas);
            command2.Parameters.AddWithValue("@FechaRenovacion", ((TOCuentaCreditoPersonal)t.Cuenta).FechaRenovacion);



            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public List<TOCuentaCreditoPersonal> getCuentasCreditoPersonal(string cedula)
        {
            SqlCommand command = new SqlCommand("getCreditoPersonalporCliente", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader reader;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            List<TOCuentaCreditoPersonal> cuentas = new List<TOCuentaCreditoPersonal>();

            while (reader.Read())
            {
                cuentas.Add(new TOCuentaCreditoPersonal
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
                });
            }
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            return cuentas;
        }


    }

}
