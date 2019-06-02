using Parcial1_LeonardoEmil.BLL;
using Parcial1_LeonardoEmil.Entidades;
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
    public partial class cConsultaInventario : Form
    {
        public cConsultaInventario()
        {
            InitializeComponent();
        }

        public void CargarInventario()
        {
            Inventarios inventario = new Inventarios();
            inventario = InventariosBLL.Buscar(1);
            if (inventario == null)
                MessageBox.Show("No Hay Producto Registrado","Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            ValorInventariotextBox.Text = Convert.ToString(inventario.TotalInventario);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
