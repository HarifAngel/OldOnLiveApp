using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLive1.Forms
{
    public partial class AddProductos : Form
    {
        public string id, producto, precio, live;
        

        public AddProductos()
        {
            InitializeComponent();
        }
        public void UpdateInfoProducto()
        {
            btnAgregar.Text = "Actualizar";
            lblID.Text = "ID Producto:";
            txtNombreProducto.Text = producto;
            txtPrecio.Text = precio;
            txtLive.Text = live;
            lblTextID.Text = id;
        }
        public void AddInfoProducto()
        {
            btnAgregar.Text = "Guardar";
            lblID.Text = "ID Cliente:";


        }
        public void Clear()
        {
            txtNombreProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtLive.Text = string.Empty;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar<=255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nombre del Producto vacio");
                return;
            }
            if(txtPrecio.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Precio vacio");
                return;
            }
            if (txtLive.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Numero de Live vacio");
                return;
            }
            if (btnAgregar.Text == "Guardar")
            {

                Productos prd = new Productos(txtNombreProducto.Text.Trim(),txtPrecio.Text.Trim(),txtLive.Text.Trim(),0,lblTextID.Text.Trim());
                DbfbVentas.AddProducto(prd);
                Clear();
                this.Close();
            }
            if (btnAgregar.Text == "Actualizar")
            {
                Productos prd = new Productos(txtNombreProducto.Text.Trim(), txtPrecio.Text.Trim(), txtLive.Text.Trim(), 0, lblTextID.Text.Trim());
                DbfbVentas.UpdateProducto(prd, id);
                this.Close();
            }

        }
    }
}
