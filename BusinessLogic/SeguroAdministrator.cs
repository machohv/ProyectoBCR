using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class SeguroAdministrator
    {
        private DAOSeguro daoSeguro = new DAOSeguro();
        public Seguro getSeguro(string cedula)
        {
            TOSeguro s = daoSeguro.getSeguro(cedula);
            if (s != null)
            {
                return new Seguro
                {
                    CodigoSeguro = s.CodigoSeguro,
                    Cedula = s.Cedula,
                    TipoSeguro = s.TipoSeguro,
                    Asegurado = s.Asegurado,
                    ValorSeguro = s.ValorSeguro
                };
            }
            return null;
        }

        public List<Seguro> getSeguros()
        {
            List<Seguro> retorno = new List<Seguro>();
            List<TOSeguro> listTO = daoSeguro.getSeguros();
            foreach (TOSeguro s in listTO)
            {
                retorno.Add(new Seguro
                {
                    CodigoSeguro = s.CodigoSeguro,
                    Cedula = s.Cedula,
                    TipoSeguro = s.TipoSeguro,
                    Asegurado = s.Asegurado,
                    ValorSeguro = s.ValorSeguro

                });
            }
            return retorno;
        }

        public void AddSeguro(Seguro s)
        {

            daoSeguro.AddSeguro(new TOSeguro
            {
                CodigoSeguro = s.CodigoSeguro,
                Cedula = s.Cedula,
                TipoSeguro = s.TipoSeguro,
                Asegurado = s.Asegurado,
                ValorSeguro = s.ValorSeguro

            });
        }

        public void EditSeguro(Seguro s)
        {
            daoSeguro.updateSeguro(convertToTOSeguro(s));
        }

        public void deleteSeguro(string cedula)
        {
            daoSeguro.deleteSeguro(cedula);
        }

        public TOSeguro convertToTOSeguro(Seguro s)
        {
            return new TOSeguro
            {
                CodigoSeguro = s.CodigoSeguro,
                Cedula = s.Cedula,
                TipoSeguro = s.TipoSeguro,
                Asegurado = s.Asegurado,
                ValorSeguro = s.ValorSeguro
            };
        }
        public Seguro convertToSeguro(TOSeguro s)
        {
            return new Seguro
            {
                CodigoSeguro = s.CodigoSeguro,
                Cedula = s.Cedula,
                TipoSeguro = s.TipoSeguro,
                Asegurado = s.Asegurado,
                ValorSeguro = s.ValorSeguro
            };
        }
    }
}