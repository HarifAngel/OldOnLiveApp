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
    public partial class FormProductos : Form
    {
        AddProductos form;
        public FormProductos()
        {
            InitializeComponent();
            form = new AddProductos();

        }

        public void Display()
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre, Fecha FROM cliente_table", dataGridViewProductos);
            DbfbVentas.DisplayAndSearch("SELECT producto_table.ID, producto_table.Producto, producto_table.Precio, producto_table.Live, producto_table.Fecha, producto_table.Pagado, cliente_table.Nombre FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID ORDER BY producto_table.Fecha DESC", dataGridViewPrd);
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormAddCliente form = new FormAddCliente();
            form.ShowDialog();
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre, Fecha FROM cliente_table", dataGridViewProductos);
            
        }

        private void FormProductos_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchProductos_TextChanged(object sender, EventArgs e)
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre, Fecha FROM cliente_table WHERE Nombre LIKE '%"+ txtSearchProductos.Text +"%'", dataGridViewProductos);
        }

        private void dataGridViewPrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if (e.RowIndex == -1) return;
                form.Clear();
                form.id = dataGridViewPrd.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.producto = dataGridViewPrd.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.precio = dataGridViewPrd.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.live =dataGridViewPrd.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfoProducto();
                form.ShowDialog();
                Display();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex == -1) return;
                if (MessageBox.Show("Quieres eliminar el Producto "+ dataGridViewPrd.Rows[e.RowIndex].Cells[2].Value.ToString() + "? Toda su informacion de eliminara", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbfbVentas.DeleteProducto(dataGridViewPrd.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == -1) return;
                form.Clear();
                form.lblTextID.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.AddInfoProducto();
                form.ShowDialog();
                DbfbVentas.DisplayAndSearch("SELECT producto_table.ID, producto_table.Producto, producto_table.Precio, producto_table.Live, producto_table.Fecha, producto_table.Pagado, cliente_table.Nombre FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID ORDER BY producto_table.Fecha DESC", dataGridViewPrd);
                return;
            }
        }
    }
}
