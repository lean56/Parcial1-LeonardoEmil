using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Parcial1_LeonardoEmil.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Constr") { }

        public DbSet<Productos> Producto { get; set; }
    }
}
