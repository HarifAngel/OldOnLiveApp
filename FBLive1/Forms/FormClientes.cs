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
    public partial class FormClientes : Form
    {
        string idCliente;
        AddProductos form;
        public FormClientes()
        {
            InitializeComponent();
            form = new AddProductos();

        }

        public void Display()
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre FROM cliente_table", dgvClientes);
        }

        private void FormClientes_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre FROM cliente_table WHERE Nombre LIKE '%" + txtBuscar.Text + "%'", dgvClientes);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == -1) return;
                lblNombreCliente.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                idCliente = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                DbfbVentas.DisplayProductosCliente(idCliente, dgvProductosCliente);
                dgvProductosCliente.FirstDisplayedScrollingRowIndex = dgvProductosCliente.Rows.Count - 1;
                DbfbVentas.DisplayProductosClienteSum(idCliente, dgvTotal);
                return;
            }
        }

        private void dgvProductosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 6)
            {
                if (e.RowIndex == -1) return;
                string idProducto = dgvProductosCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pagado = dgvProductosCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
                int index = dgvProductosCliente.CurrentCell.RowIndex;
                if(pagado == "False")
                {
                    DbfbVentas.UpdatePagarProducto(idProducto, "1");
                    DbfbVentas.DisplayProductosCliente(idCliente, dgvProductosCliente);
                    dgvProductosCliente.FirstDisplayedScrollingRowIndex = index;
                    DbfbVentas.DisplayProductosClienteSum(idCliente, dgvTotal);
                }
                if(pagado == "True")
                {
                    DbfbVentas.UpdatePagarProducto(idProducto, "0");
                    DbfbVentas.DisplayProductosCliente(idCliente, dgvProductosCliente);
                    dgvProductosCliente.FirstDisplayedScrollingRowIndex = index;
                    DbfbVentas.DisplayProductosClienteSum(idCliente, dgvTotal);
                }
            }
            if(e.ColumnIndex == 0) 
            {
                if (e.RowIndex == -1) return;
                form.Clear();
                form.id = dgvProductosCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.producto = dgvProductosCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.precio = dgvProductosCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.live = dgvProductosCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfoProducto();
                form.ShowDialog();
                DbfbVentas.DisplayProductosCliente(idCliente, dgvProductosCliente);
                dgvProductosCliente.FirstDisplayedScrollingRowIndex = dgvProductosCliente.Rows.Count - 1;
                DbfbVentas.DisplayProductosClienteSum(idCliente, dgvTotal);
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex == -1) return;
                if (MessageBox.Show("Quieres eliminar el Producto " + dgvProductosCliente.Rows[e.RowIndex].Cells[2].Value.ToString() + "? Toda su informacion de eliminara", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbfbVentas.DeleteProducto(dgvProductosCliente.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DbfbVentas.DisplayProductosCliente(idCliente, dgvProductosCliente);
                    dgvProductosCliente.FirstDisplayedScrollingRowIndex = dgvProductosCliente.Rows.Count - 1;
                    DbfbVentas.DisplayProductosClienteSum(idCliente, dgvTotal);
                }
                return;
            }
        }
    }
}
