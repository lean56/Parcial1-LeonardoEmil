using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_LeonardoEmil.UI.Registro;

namespace Parcial1_LeonardoEmil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto rp = new RegistroProducto();
            rp.Show();
        }

    
    }
}
