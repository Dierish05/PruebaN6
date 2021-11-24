using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Calendario
    {
        public int Id { get; set; }
        public decimal MontoPrestamo { get; set; }
        public int Terminos { get; set; }
        public DateTime FechaDePago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Interes { get; set; } //tasa
        public decimal Principal { get; set; }
        public decimal Cuota { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal PrincipalPagado { get; set; }
        public decimal CuotaPagado { get; set; }
        public Estado Estado { get; set; }
    }
}
