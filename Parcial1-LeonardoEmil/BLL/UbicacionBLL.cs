using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_LeonardoEmil.BLL;
using Parcial1_LeonardoEmil.DAL;
using Parcial1_LeonardoEmil.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial1_LeonardoEmil.BLL
{
    public class UbicacionBLL
    {
        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Add(ubicacion) != null)
                    paso = contexto.SaveChanges() > 0;
                paso = true;

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

        public static bool Modificar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(ubicacion).State = EntityState.Modified;
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

        public static bool Duplicado(string descripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Any(p => p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }

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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Ubicacion.Find(id);
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

        public static Ubicaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ubicaciones ubicacion = new Ubicaciones();

            try
            {
                ubicacion = contexto.Ubicacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ubicacion;
        }

        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicacion)
        {
            List<Ubicaciones> Lista = new List<Ubicaciones>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Ubicacion.Where(ubicacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

    }
}