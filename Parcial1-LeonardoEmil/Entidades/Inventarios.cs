using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LeonardoEmil.Entidades
{
   public class Inventarios
    {
        [Key]
        public int InventarioId { get; set; }
        public int TotalInventario { get; set; }
    }
}
