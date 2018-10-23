using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }
        public string Nombre { get; set; }
        public Decimal Balance { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<Prestamos> Prestamos { get; set; }
      
        public Cuentas()
        {
                
        }

        public Cuentas(int cuentaId, string nombre, Decimal balance, DateTime fecha)
        {
            this.CuentaId = cuentaId;
            this.Nombre = nombre;
            this.Balance = balance;
            this.Fecha = fecha;
        }
    }
}
