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
    public partial class FormConfiguracion : Form
    {
        FormAddCliente form;
        public FormConfiguracion()
        {
            InitializeComponent();
            form = new FormAddCliente();
        }

        public void Display()
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre, Fecha FROM cliente_table", dataGridViewConfig);
        }

        private void FormConfiguracion_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchConfig_TextChanged(object sender, EventArgs e)
        {
            DbfbVentas.DisplayAndSearch("SELECT ID, Nombre, Fecha FROM cliente_table WHERE Nombre LIKE '%" + txtSearchConfig.Text + "%'", dataGridViewConfig);
        }

        private void dataGridViewConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == -1) return;
                form.Clear();
                form.id = dataGridViewConfig.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridViewConfig.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.UpdateInfoCliente();
                form.ShowDialog();
                Display();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Quieres eliminar al cliente? Toda su informacion de eliminara", "Informacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbfbVentas.DeleteCliente(dataGridViewConfig.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
