﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_LeonardoEmil.Entidades;
using Parcial1_LeonardoEmil.DAL;
using System.Data.Entity;

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
    }
}
