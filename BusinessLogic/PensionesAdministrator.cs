﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class PensionesAdministrator
    {
        private DAOPensiones daoPension = new DAOPensiones();
        public Pensiones getPension(string cedula)
        {
            TOPensiones p = daoPension.getPension(cedula);
            if (p != null)
            {
                return new Pensiones
                {
                    CodigoPension = p.CodigoPension,
                    Cedula = p.Cedula,
                    TipoPension = p.TipoPension,
                    ValorPension = p.ValorPension
                };
            }
            return null;
        }

        public List<Pensiones> getPensiones()
        {
            List<Pensiones> retorno = new List<Pensiones>();
            List<TOPensiones> listTO = daoPension.getPensiones();
            foreach (TOPensiones p in listTO)
            {
                retorno.Add(new Pensiones
                {
                    CodigoPension = p.CodigoPension,
                    Cedula = p.Cedula,
                    TipoPension = p.TipoPension,
                    ValorPension = p.ValorPension

                });
            }
            return retorno;
        }

        public void AddPension(Pensiones p)
        {
                       
            daoPension.AddPension(new TOPensiones
            {
                CodigoPension = p.CodigoPension,
                Cedula = p.Cedula,
                TipoPension = p.TipoPension,
                ValorPension = p.ValorPension

            });
        }

        public void EditPension(Pensiones p)
        {
            daoPension.updatePension(convertToTOPensiones(p));
        }

        public void deletePension(string cedula)
        {
            daoPension.deletePension(cedula);
        }

        public TOPensiones convertToTOPensiones(Pensiones p)
        {
            return new TOPensiones
            {
                CodigoPension = p.CodigoPension,
                Cedula = p.Cedula,
                TipoPension = p.TipoPension,
                ValorPension = p.ValorPension
            };
        }
        public Pensiones convertToPensiones(TOPensiones p)
        {
            return new Pensiones
            {
                CodigoPension = p.CodigoPension,
                Cedula = p.Cedula,
                TipoPension = p.TipoPension,
                ValorPension = p.ValorPension
            };
        }
    }
}