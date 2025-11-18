namespace FBLive1.Forms
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dgvProductosCliente = new System.Windows.Forms.DataGridView();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Live = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxPagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Consultar});
            this.dgvClientes.GridColor = System.Drawing.Color.White;
            this.dgvClientes.Location = new System.Drawing.Point(20, 75);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(1);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 102;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.RowTemplate.Height = 40;
            this.dgvClientes.ShowEditingIcon = false;
            this.dgvClientes.Size = new System.Drawing.Size(295, 366);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Numero";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Consultar
            // 
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.HeaderText = "";
            this.Consultar.MinimumWidth = 12;
            this.Consultar.Name = "Consultar";
            this.Consultar.ReadOnly = true;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total No Pagado:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(96, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvProductosCliente
            // 
            this.dgvProductosCliente.AllowUserToAddRows = false;
            this.dgvProductosCliente.AllowUserToDeleteRows = false;
            this.dgvProductosCliente.AllowUserToResizeRows = false;
            this.dgvProductosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.Producto,
            this.Precio,
            this.Live,
            this.checkBoxPagado,
            this.ColumnEditar,
            this.ColumnEliminar});
            this.dgvProductosCliente.GridColor = System.Drawing.Color.White;
            this.dgvProductosCliente.Location = new System.Drawing.Point(326, 75);
            this.dgvProductosCliente.Margin = new System.Windows.Forms.Padding(1);
            this.dgvProductosCliente.MultiSelect = false;
            this.dgvProductosCliente.Name = "dgvProductosCliente";
            this.dgvProductosCliente.RowHeadersVisible = false;
            this.dgvProductosCliente.RowHeadersWidth = 102;
            this.dgvProductosCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductosCliente.RowTemplate.Height = 40;
            this.dgvProductosCliente.ShowEditingIcon = false;
            this.dgvProductosCliente.Size = new System.Drawing.Size(644, 366);
            this.dgvProductosCliente.TabIndex = 11;
            this.dgvProductosCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosCliente_CellClick);
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AllowUserToResizeColumns = false;
            this.dgvTotal.AllowUserToResizeRows = false;
            this.dgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Suma});
            this.dgvTotal.GridColor = System.Drawing.Color.White;
            this.dgvTotal.Location = new System.Drawing.Point(611, 443);
            this.dgvTotal.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTotal.MultiSelect = false;
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            this.dgvTotal.RowHeadersWidth = 102;
            this.dgvTotal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTotal.RowTemplate.Height = 40;
            this.dgvTotal.ShowEditingIcon = false;
            this.dgvTotal.Size = new System.Drawing.Size(105, 66);
            this.dgvTotal.TabIndex = 12;
            // 
            // Suma
            // 
            this.Suma.DataPropertyName = "SUM(precio)";
            this.Suma.HeaderText = "Suma";
            this.Suma.MinimumWidth = 12;
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(333, 37);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 22);
            this.lblNombreCliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(833, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pagar/Revertir";
            // 
            // IDProducto
            // 
            this.IDProducto.DataPropertyName = "ID";
            this.IDProducto.HeaderText = "Numero";
            this.IDProducto.MinimumWidth = 12;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 12;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 12;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Live
            // 
            this.Live.DataPropertyName = "Live";
            this.Live.HeaderText = "Live";
            this.Live.MinimumWidth = 12;
            this.Live.Name = "Live";
            this.Live.ReadOnly = true;
            // 
            // checkBoxPagado
            // 
            this.checkBoxPagado.DataPropertyName = "Pagado";
            this.checkBoxPagado.HeaderText = "Pagado";
            this.checkBoxPagado.MinimumWidth = 12;
            this.checkBoxPagado.Name = "checkBoxPagado";
            // 
            // ColumnEditar
            // 
            this.ColumnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEditar.HeaderText = "";
            this.ColumnEditar.Name = "ColumnEditar";
            this.ColumnEditar.Text = "Editar";
            this.ColumnEditar.UseColumnTextForButtonValue = true;
            // 
            // ColumnEliminar
            // 
            this.ColumnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEliminar.HeaderText = "";
            this.ColumnEliminar.Name = "ColumnEliminar";
            this.ColumnEliminar.Text = "Eliminar";
            this.ColumnEliminar.UseColumnTextForButtonValue = true;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 615);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.dgvProductosCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(996, 654);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Shown += new System.EventHandler(this.FormClientes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgvProductosCliente;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Consultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Live;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxPagado;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEliminar;
    }
}