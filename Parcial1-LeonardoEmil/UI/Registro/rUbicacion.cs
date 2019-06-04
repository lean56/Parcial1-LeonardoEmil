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

namespace Parcial1_LeonardoEmil.UI.Registro
{
    public partial class rUbicacion : Form
    {
        public rUbicacion()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Ubicaciones LlenarClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();

            ubicacion.UbicacionId = Convert.ToInt32(IDnumericUpDown.Value);
            ubicacion.Descripcion = DescripciontextBox.Text;

            return ubicacion;
        }

        private void LlenaCampo(Ubicaciones ubicacion)
        {
            IDnumericUpDown.Value = ubicacion.UbicacionId;
            DescripciontextBox.Text = ubicacion.Descripcion;
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            try
            {
                if (UbicacionBLL.Duplicado(DescripciontextBox.Text))
                {
                    paso = false;
                    MyErrorProvider.SetError(DescripciontextBox, "La descripcion ya esta registrada");
                }
            }
            catch (Exception)
            {
                throw;
            }

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            Ubicaciones ubicacion = UbicacionBLL.Buscar((int)IDnumericUpDown.Value);

            return (ubicacion != null);
        }



        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Ubicaciones ubicacion;

            bool paso = false;

            if (!Validar())
                return;

            ubicacion = LlenarClase();


            if (IDnumericUpDown.Value == 0)
            {
                paso = UbicacionBLL.Guardar(ubicacion);
            }

            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = UbicacionBLL.Modificar(ubicacion);

                MessageBox.Show("Ubicacion Modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar();

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if (IDnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IDnumericUpDown, "El campo ID no puede estar vacio");
                IDnumericUpDown.Focus();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Eliminar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (UbicacionBLL.Eliminar(id))
                {
                    MessageBox.Show("Ubicacion Eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MyErrorProvider.SetError(IDnumericUpDown, "Id no Existe");

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Ubicaciones ubicacion = new Ubicaciones();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            ubicacion = UbicacionBLL.Buscar(id);

            if (ubicacion != null)
            {
                MessageBox.Show("Ubicacion Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(ubicacion);
            }
            else
            {
                MessageBox.Show("Ubicacion no Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
