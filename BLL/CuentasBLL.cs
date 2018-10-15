using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CuentasBLL
    {
        public static bool Guardar(Cuentas cuentas)
        {
            using (var context = new Respository<Cuentas>())
            {
                try
                {
                    if (Buscar(p => p.CuentaId == cuentas.CuentaId) == null)
                    {
                        return context.Guardar(cuentas);
                    }
                    else
                    {
                        return context.Modificar(cuentas);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static Cuentas Buscar(Expression<Func<Cuentas, bool>> criterio)
        {
            using (var context = new Respository<Cuentas>())
            {
                try
                {
                    return context.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Cuentas cuentas)
        {
            using (var context = new Respository<Cuentas>())
            {
                try
                {
                    return context.Eliminar(cuentas);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Cuentas> GetListAll()
        {
            using (var context = new Respository<Cuentas>())
            {
                try
                {
                    return context.GetListAll();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Cuentas> GetList(Expression<Func<Cuentas, bool>> criterio)
        {
            using (var context = new Respository<Cuentas>())
            {
                try
                {
                    return context.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
