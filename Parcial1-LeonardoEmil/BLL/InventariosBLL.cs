using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_LeonardoEmil.Entidades;
using Parcial1_LeonardoEmil.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial1_LeonardoEmil.BLL
{
   public class InventariosBLL
    {
        public static bool Guardar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inventario.Add(inventario) != null)
                    paso = contexto.SaveChanges() > 0;

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Inventarios inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(inventario).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Inventarios> GetList(Expression<Func<Inventarios, bool>> inventario)
        {
            List<Inventarios> Lista = new List<Inventarios>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Inventario.Where(inventario).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

        public static Inventarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventarios inventario = new Inventarios();

            try
            {
                inventario = contexto.Inventario.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return inventario;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Inventario.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

    }
}
