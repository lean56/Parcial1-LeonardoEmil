using Parcial1_LeonardoEmil.Entidades;
using Parcial1_LeonardoEmil.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_LeonardoEmil.UI.Consulta
{
    public partial class ConsultaInventario : Form
    {
        public ConsultaInventario()
        {
            InitializeComponent();
            CargarInventario();
        }

        public void CargarInventario()
        {
            Inventarios inventario = new Inventarios();
            inventario = InventariosBLL.Buscar(1);

            ValorInventariotextBox.Text = Convert.ToString(inventario.TotalInventario);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            CargarInventario();
        }
    }
}
