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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }
        public void Display()
        {
            DbfbVentas.DisplayAndSearch("SELECT cliente_table.Nombre, Producto, Precio, Live FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID", dgvReporteLive);
            DbfbVentas.DisplayAndSearch("SELECT cliente_table.Nombre, Producto, Precio FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID", dgvReporteTotal);
            DbfbVentas.DisplayAndSearch("SELECT SUM(Precio) FROM producto_table", dgvTotalVentasTotales);
            DbfbVentas.DisplayAndSearch("SELECT cliente_table.Nombre, SUM(Precio) AS Total FROM producto_table INNER JOIN cliente_table ON cliente_table.ID=producto_table.IDCliente GROUP BY producto_table.IDCliente ORDER BY Total DESC", dgvReporteTotalNopagado);
        }

        private void FormReportes_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtLive_TextChanged(object sender, EventArgs e)
        {
            if(txtLive.Text == "")
            {
                DbfbVentas.DisplayAndSearch("SELECT cliente_table.Nombre, Producto, Precio, Live FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID", dgvReporteLive);
            }
            DbfbVentas.DisplayAndSearch("SELECT cliente_table.Nombre, Producto, Precio, Live FROM producto_table INNER JOIN cliente_table ON producto_table.IDCliente=cliente_table.ID WHERE Live LIKE '%" + txtLive.Text + "%'", dgvReporteLive);
            DbfbVentas.DisplayAndSearch("SELECT SUM(Precio) FROM Producto_table WHERE Live LIKE '%" + txtLive.Text + "%'", dgvLiveTotal);
        }
    }
}
