using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Prestamo
{
    public class CalendarioCalcular : BDPrestamo
    {
        public decimal CalcularCuota(decimal principal, decimal interes)
        {
            return Math.Round(principal + interes);
        }

        public decimal CalcularInteres(decimal monto, decimal tasa, decimal terminos)
        {
            return Math.Round(monto * tasa / terminos);
        }

        public decimal CalcularPrincipal(decimal monto, decimal tasa, decimal terminos)
        {
            return Math.Round(monto * (tasa + 1) / terminos);
        }

        public List<Calendario> GetBy(Predicate<Calendario> predicate)
        {
            return listaprestamos.FindAll(predicate);
        }

        public int GetLastIndex()
        {
            if (listaprestamos.Count == 0)
            {
                return 0;
            }

            return listaprestamos.Count;
        }
    }
}
