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
    }
}
