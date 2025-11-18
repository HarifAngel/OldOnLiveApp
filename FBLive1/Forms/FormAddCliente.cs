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
    public partial class FormAddCliente : Form
    {
        public string id, name;
        

        public FormAddCliente()
        {
            InitializeComponent();
            
        }

        public void UpdateInfoCliente()
        {
            btnGuardarAgregarCliente.Text = "Actualizar";
            txtNombre.Text = name;
        }

        public void Clear()
        {
            txtNombre.Text = string.Empty;
        }

       

        private void btnGuardarAgregarCliente_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nombre del Cliente vacio");
                return;
            }
            if(btnGuardarAgregarCliente.Text == "Guardar")
            {
                
                Cliente clnt = new Cliente(txtNombre.Text.Trim());
                DbfbVentas.AddCliente(clnt);
                Clear();
                this.Close();
               
           
            }
            if (btnGuardarAgregarCliente.Text == "Actualizar")
            {
                Cliente clnt = new Cliente(txtNombre.Text.Trim());
                DbfbVentas.UpdateCliente(clnt, id);
                this.Close();
            }
            
        }
    }
}
