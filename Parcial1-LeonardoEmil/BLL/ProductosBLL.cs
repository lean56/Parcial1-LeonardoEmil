﻿using System;
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
    public class ProductosBLL
    {
     
        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Producto.Add(producto) != null)
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

        public static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Producto.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

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

        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos producto = new Productos();

            try
            {
                producto = contexto.Producto.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos,bool>>producto)
        {
            List<Productos> Lista = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {

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

    }
}
