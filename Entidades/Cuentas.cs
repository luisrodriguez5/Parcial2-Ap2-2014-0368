using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuentas
    {
        public int CuentaId { get; set; }
        public string Nombre { get; set; }
        public Decimal Balance { get; set; }

        public Cuentas()
        {
                
        }
    }
}
