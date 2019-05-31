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
            var listado = new List<Productos>();

            listado = ProductosBLL.GetList(p => true);

            ValorInventariodataGridView.DataSource = null;
            ValorInventariodataGridView.DataSource = listado;

            int total = 0;
            foreach (DataGridViewRow producto in ValorInventariodataGridView.Rows)
            {
                total += Convert.ToInt32(producto.Cells["ValorInventario"].Value);
            }
            ValorInventarionumericUpDown.Text = Convert.ToString(total);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            CargarInventario();
        }
    }
}
