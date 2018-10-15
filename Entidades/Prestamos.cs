using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamos
    {
        public int PrestamoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Decimal Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaSaldo { get; set; }


        public Prestamos()
        {

        }
    }
}
