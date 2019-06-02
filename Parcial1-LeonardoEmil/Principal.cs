using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Parcial1_LeonardoEmil.UI.Registro;
using Parcial1_LeonardoEmil.UI.Consulta;

namespace Parcial1_LeonardoEmil
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wnsg, int wparam, int lparam);

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width =200;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRest.Visible = true;
            IconoMax.Visible = false;
        }

        private void IconoRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoRest.Visible = false;
            IconoMax.Visible = true;
        }

        private void IconoMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void Productosbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rProductos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cConsultaInventario());
        }
    }
}
