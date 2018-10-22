using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Decimal Monto { get; set; }
        public int NoCuotas { get; set; }
        public int CoutaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaSaldo { get; set; }


        public Prestamos()
        {

        }
        public Prestamos(int prestamoid, string nombre, string direccion, Decimal Monto, int noCuotas)
        {
            this.PrestamoId = prestamoid;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Monto = Monto;
            this.NoCuotas = noCuotas;

        }
    }
}
