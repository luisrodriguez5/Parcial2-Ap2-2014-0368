using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuotas
    {
        public int CuotaId { get; set; }
        public string Descripsion  { get; set; }
        public int Capital  { get; set; }
        public Decimal Interes  { get; set; }
        public DateTime Fecha  { get; set; }
        public int PrestamoId { get; set; }
    }
}
