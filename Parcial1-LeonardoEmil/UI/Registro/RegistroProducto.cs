using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_LeonardoEmil.BLL;
using Parcial1_LeonardoEmil.Entidades;


namespace Parcial1_LeonardoEmil.UI.Registro
{
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistencianumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            ValorInventarionumericUpDown.Value = 0;
        }

        private Productos LlenarClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = Convert.ToInt32(IdnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            producto.Costo = Convert.ToInt32(CostonumericUpDown.Value);
            producto.ValorInventario = Convert.ToInt32(ValorInventarionumericUpDown.Value);

            return producto;
        }

        private Inventarios LLenarInventario()
        {
            Inventarios inventario = new Inventarios();

            inventario.TotalInventario = Convert.ToInt32(ValorInventarionumericUpDown.Value);

            return inventario;
        }

        private void LlenaCampo(Productos producto)
        {
            IdnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistencianumericUpDown.Value = producto.Existencia;
            CostonumericUpDown.Value = Convert.ToInt32(producto.Costo);
            ValorInventarionumericUpDown.Value = Convert.ToInt32(producto.ValorInventario);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos producto = ProductosBLL.Buscar((int)IdnumericUpDown.Value);

            return (producto != null);
        }

        private bool ExisteEnLaBaseDeDatos2()
        {
            Inventarios inventarios = InventariosBLL.Buscar((int)IdnumericUpDown.Value);

            return (inventarios != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            if (ExistencianumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(ExistencianumericUpDown, "El campo Existencia no puede estar vacio");
                ExistencianumericUpDown.Focus();
                paso = false;
            }

            if (CostonumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostonumericUpDown, "El campo Costo no puede estar vacio");
                CostonumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inventarios inventario = new Inventarios();

            Productos producto;
            // Inventarios inventario;

            bool paso = false;

            if (!Validar())
                return;

            producto = LlenarClase();
            //inventario = LLenarInventario();

            if (IdnumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(producto);
           
                // paso = InventariosBLL.Guardar(inventario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
                paso = ProductosBLL.Modificar(producto);
                
                //  paso = InventariosBLL.Modificar(inventario);
                MessageBox.Show("Producto Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           Limpiar();

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MessageBox.Show("Error al Guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            MyErrorProvider.Clear();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Productos producto = new Productos();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            producto = ProductosBLL.Buscar(id);

            if(producto !=null)
            {
                MessageBox.Show("Producto Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(producto);
            }
            else
            {
                MessageBox.Show("Producto no Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
      
            if (IdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown, "El campo ID no puede estar vacio");
                IdnumericUpDown.Focus();
            }
            else
            {
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("Producto Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MyErrorProvider.SetError(IdnumericUpDown, "Id no Existe");
            }
           
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int costo = Convert.ToInt32(CostonumericUpDown.Value);
            int existencia = Convert.ToInt32(ExistencianumericUpDown.Value);

            ValorInventarionumericUpDown.Value = ProductosBLL.ValorInventario(costo, existencia);
        }

        private void ExistencianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int costo = Convert.ToInt32(CostonumericUpDown.Value);
            int existencia = Convert.ToInt32(ExistencianumericUpDown.Value);

            ValorInventarionumericUpDown.Value = ProductosBLL.ValorInventario(costo, existencia);
        }
    }

}
