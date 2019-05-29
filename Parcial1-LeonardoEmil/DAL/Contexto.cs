using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parcial1_LeonardoEmil.Entidades;


namespace Parcial1_LeonardoEmil.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Producto { get; set; }

        public Contexto() : base("Constr") { }
    }
}
