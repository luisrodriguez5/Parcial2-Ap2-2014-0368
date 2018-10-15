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
    public class PrestamosBLL
    {
        public static bool Guardar(Prestamos prestamos)
        {
            using (var context = new Respository<Prestamos>())
            {
                try
                {
                    if (Buscar(p => p.PrestamoId == prestamos.PrestamoId) == null)
                    {
                        return context.Guardar(prestamos);
                    }
                    else
                    {
                        return context.Modificar(prestamos);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static Prestamos Buscar(Expression<Func<Prestamos, bool>> criterio)
        {
            using (var context = new Respository<Prestamos>())
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

        public static bool Eliminar(Prestamos prestamos)
        {
            using (var context = new Respository<Prestamos>())
            {
                try
                {
                    return context.Eliminar(prestamos);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Prestamos> GetListAll()
        {
            using (var context = new Respository<Prestamos>())
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

        public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> criterio)
        {
            using (var context = new Respository<Prestamos>())
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
