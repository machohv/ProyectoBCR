using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class CuentaCreditoPersonalAdministrator
    {
        private DAOCuentaCreditoPersonal daoCreditoPersonal = new DAOCuentaCreditoPersonal();
        private PersonasAdministrator personasAdministrator = new PersonasAdministrator();
        public void AddCuentaCreditoPersonal(Tarjeta t)
        {
            daoCreditoPersonal.addCuentaCreditoPersonal(new TOTarjeta
            {
                CasaMatriz = t.CasaMatriz,
                imgSrc = t.imgSrc,
                Descripcion = t.Descripcion,
                Cuenta = new TOCuentaCreditoPersonal {
                    Divisa = t.Cuenta.Divisa,
                    Taza = ((CuentaCreditoPersonal)t.Cuenta).Taza,
                    Plazo = ((CuentaCreditoPersonal)t.Cuenta).Plazo,
                    Cliente = personasAdministrator.convertToTOPersona((Persona)t.Cliente),
                    Categoria = ((CuentaCreditoPersonal)t.Cuenta).Categoria
                },
                Cliente = personasAdministrator.convertToTOPersona((Persona)t.Cliente)
            });
        }

        public List<Tarjeta> getCuentasCreditoPersonal()
        {
            List<Tarjeta> retorno = new List<Tarjeta>();
            List<TOTarjeta> listTO = daoCreditoPersonal.getCuentasCreditoPersonal();
            foreach (TOTarjeta t in listTO)
            {
                retorno.Add(new Tarjeta
                {
                    NumeroTarjeta = t.NumeroTarjeta,
                    CasaMatriz = t.CasaMatriz,
                    CVV = t.CVV,
                    imgSrc = t.imgSrc,
                    Descripcion = t.Descripcion,
                    Pin = t.Pin,
                    Cliente = personasAdministrator.convertToPersona((TOPersona)t.Cliente),
                    Cuenta = new CuentaCreditoPersonal
                    {
                        Balance = t.Cuenta.Balance,
                        SaldoBloqueado = t.Cuenta.SaldoBloqueado,
                        SaldoCongelado = t.Cuenta.SaldoCongelado,
                        Divisa = t.Cuenta.Divisa,
                        Taza = ((TOCuentaCreditoPersonal)t.Cuenta).Taza,
                        Millas = ((TOCuentaCreditoPersonal)t.Cuenta).Millas,
                        Categoria = ((TOCuentaCreditoPersonal)t.Cuenta).Categoria,
                        FechaCorte = ((TOCuentaCreditoPersonal)t.Cuenta).FechaCorte,
                        FechaRenovacion = ((TOCuentaCreditoPersonal)t.Cuenta).FechaRenovacion,
                        NumeroSinpe = t.Cuenta.NumeroSinpe,
                        NumeroCuenta = t.Cuenta.NumeroCuenta,
                        Cliente = personasAdministrator.convertToPersona((TOPersona)((TOCuentaCreditoPersonal)t.Cuenta).Cliente)
                    }

                });
            }
            return retorno;
        }

        public Tarjeta getCuentaCreditoPersonal(string numeroCuenta)
        {
            TOTarjeta t = daoCreditoPersonal.getCuentaCreditoPersonal(numeroCuenta);
            if (t == null)
            {
                return null;
            } else
            {
                return new Tarjeta
                {
                    NumeroTarjeta = t.NumeroTarjeta,
                    CasaMatriz = t.CasaMatriz,
                    CVV = t.CVV,
                    imgSrc = t.imgSrc,
                    Descripcion = t.Descripcion,
                    Pin = t.Pin,
                    Cliente = personasAdministrator.convertToPersona((TOPersona)t.Cliente),
                    Cuenta = new CuentaCreditoPersonal
                    {
                        Balance = t.Cuenta.Balance,
                        SaldoBloqueado = t.Cuenta.SaldoBloqueado,
                        SaldoCongelado = t.Cuenta.SaldoCongelado,
                        Divisa = t.Cuenta.Divisa,
                        Taza = ((TOCuentaCreditoPersonal)t.Cuenta).Taza,
                        Millas = ((TOCuentaCreditoPersonal)t.Cuenta).Millas,
                        Categoria = ((TOCuentaCreditoPersonal)t.Cuenta).Categoria,
                        FechaCorte = ((TOCuentaCreditoPersonal)t.Cuenta).FechaCorte,
                        FechaRenovacion = ((TOCuentaCreditoPersonal)t.Cuenta).FechaRenovacion,
                        NumeroSinpe = t.Cuenta.NumeroSinpe,
                        NumeroCuenta = t.Cuenta.NumeroCuenta,
                        Cliente = personasAdministrator.convertToPersona((TOPersona)((TOCuentaCreditoPersonal)t.Cuenta).Cliente)
                    }

                };
            }
        }

        public void EditCuentaCreditoPersonal(Tarjeta t)
        {
            daoCreditoPersonal.editCuentaCreditoPersonal(new TOTarjeta
            {
                NumeroTarjeta = t.NumeroTarjeta,
                CVV = t.CVV,
                Pin = t.Pin,
                CasaMatriz = t.CasaMatriz,
                imgSrc = t.imgSrc,
                Descripcion = t.Descripcion,
                Cuenta = new TOCuentaCreditoPersonal
                {
                    Balance = t.Cuenta.Balance,
                    FechaCorte = ((CuentaCreditoPersonal)t.Cuenta).FechaCorte,
                    FechaRenovacion = ((CuentaCreditoPersonal)t.Cuenta).FechaRenovacion,
                    Millas = ((CuentaCreditoPersonal)t.Cuenta).Millas,
                    NumeroCuenta = t.Cuenta.NumeroCuenta,
                    NumeroSinpe = t.Cuenta.NumeroCuenta,
                    SaldoBloqueado = t.Cuenta.SaldoBloqueado,
                    SaldoCongelado = t.Cuenta.SaldoCongelado,
                    Divisa = t.Cuenta.Divisa,
                    Taza = ((CuentaCreditoPersonal)t.Cuenta).Taza,
                    Plazo = ((CuentaCreditoPersonal)t.Cuenta).Plazo,
                    Cliente = personasAdministrator.convertToTOPersona((Persona)t.Cliente),
                    Categoria = ((CuentaCreditoPersonal)t.Cuenta).Categoria
                },
                Cliente = personasAdministrator.convertToTOPersona((Persona)t.Cliente)
            });
        }

        public void deleteCuentaCreditoPersona(string numeroCuenta)
        {
            daoCreditoPersonal.deleteCuentaCreditoPersonal(numeroCuenta);
        }

        public List<CuentaCreditoPersonal> getCuentasCreditoPersonal(string cedula)
        {
            List<CuentaCreditoPersonal> retorno = new List<CuentaCreditoPersonal>();
            List<TOCuentaCreditoPersonal> listTO = daoCreditoPersonal.getCuentasCreditoPersonal(cedula);
            foreach (TOCuentaCreditoPersonal c in listTO)
            {
                retorno.Add(new CuentaCreditoPersonal
                {
                    Balance = c.Balance,
                    SaldoBloqueado = c.SaldoBloqueado,
                    SaldoCongelado = c.SaldoCongelado,
                    Divisa = c.Divisa,
                    Taza = ((TOCuentaCreditoPersonal)c).Taza,
                    Millas = ((TOCuentaCreditoPersonal)c).Millas,
                    Categoria = ((TOCuentaCreditoPersonal)c).Categoria,
                    FechaCorte = ((TOCuentaCreditoPersonal)c).FechaCorte,
                    FechaRenovacion = ((TOCuentaCreditoPersonal)c).FechaRenovacion,
                    NumeroSinpe = c.NumeroSinpe,
                    NumeroCuenta = c.NumeroCuenta,
                    Cliente = personasAdministrator.convertToPersona((TOPersona)((TOCuentaCreditoPersonal)c).Cliente)

                });
            }
            return retorno;
        }
    }
}
