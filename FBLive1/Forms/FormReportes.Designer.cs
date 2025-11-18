namespace FBLive1.Forms
{
    partial class FormReportes
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
            this.dgvReporteLive = new System.Windows.Forms.DataGridView();
            this.dgvReporteTotal = new System.Windows.Forms.DataGridView();
            this.dgvReporteTotalNopagado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLive = new System.Windows.Forms.TextBox();
            this.dgvLiveTotal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTotalVentasTotales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgvReporteLive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Live = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgvReporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgvNoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDgvNoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTotalNopagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalVentasTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteLive
            // 
            this.dgvReporteLive.AllowUserToAddRows = false;
            this.dgvReporteLive.AllowUserToDeleteRows = false;
            this.dgvReporteLive.AllowUserToResizeRows = false;
            this.dgvReporteLive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteLive.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteLive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteLive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDgvReporteLive,
            this.Producto,
            this.Precio,
            this.Live});
            this.dgvReporteLive.GridColor = System.Drawing.Color.White;
            this.dgvReporteLive.Location = new System.Drawing.Point(9, 103);
            this.dgvReporteLive.Margin = new System.Windows.Forms.Padding(1);
            this.dgvReporteLive.MultiSelect = false;
            this.dgvReporteLive.Name = "dgvReporteLive";
            this.dgvReporteLive.ReadOnly = true;
            this.dgvReporteLive.RowHeadersVisible = false;
            this.dgvReporteLive.RowHeadersWidth = 102;
            this.dgvReporteLive.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReporteLive.RowTemplate.Height = 40;
            this.dgvReporteLive.ShowEditingIcon = false;
            this.dgvReporteLive.Size = new System.Drawing.Size(373, 380);
            this.dgvReporteLive.TabIndex = 5;
            // 
            // dgvReporteTotal
            // 
            this.dgvReporteTotal.AllowUserToAddRows = false;
            this.dgvReporteTotal.AllowUserToDeleteRows = false;
            this.dgvReporteTotal.AllowUserToResizeRows = false;
            this.dgvReporteTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteTotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDgvReporteTotal,
            this.dgvTotalProducto,
            this.dgvTotalPrecio});
            this.dgvReporteTotal.GridColor = System.Drawing.Color.White;
            this.dgvReporteTotal.Location = new System.Drawing.Point(396, 103);
            this.dgvReporteTotal.Margin = new System.Windows.Forms.Padding(1);
            this.dgvReporteTotal.MultiSelect = false;
            this.dgvReporteTotal.Name = "dgvReporteTotal";
            this.dgvReporteTotal.ReadOnly = true;
            this.dgvReporteTotal.RowHeadersVisible = false;
            this.dgvReporteTotal.RowHeadersWidth = 102;
            this.dgvReporteTotal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReporteTotal.RowTemplate.Height = 40;
            this.dgvReporteTotal.ShowEditingIcon = false;
            this.dgvReporteTotal.Size = new System.Drawing.Size(390, 380);
            this.dgvReporteTotal.TabIndex = 6;
            // 
            // dgvReporteTotalNopagado
            // 
            this.dgvReporteTotalNopagado.AllowUserToAddRows = false;
            this.dgvReporteTotalNopagado.AllowUserToDeleteRows = false;
            this.dgvReporteTotalNopagado.AllowUserToResizeRows = false;
            this.dgvReporteTotalNopagado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteTotalNopagado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteTotalNopagado.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteTotalNopagado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteTotalNopagado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteTotalNopagado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDgvNoPagado,
            this.TotalDgvNoPagado});
            this.dgvReporteTotalNopagado.GridColor = System.Drawing.Color.White;
            this.dgvReporteTotalNopagado.Location = new System.Drawing.Point(802, 103);
            this.dgvReporteTotalNopagado.Margin = new System.Windows.Forms.Padding(1);
            this.dgvReporteTotalNopagado.MultiSelect = false;
            this.dgvReporteTotalNopagado.Name = "dgvReporteTotalNopagado";
            this.dgvReporteTotalNopagado.ReadOnly = true;
            this.dgvReporteTotalNopagado.RowHeadersVisible = false;
            this.dgvReporteTotalNopagado.RowHeadersWidth = 102;
            this.dgvReporteTotalNopagado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReporteTotalNopagado.RowTemplate.Height = 40;
            this.dgvReporteTotalNopagado.ShowEditingIcon = false;
            this.dgvReporteTotalNopagado.Size = new System.Drawing.Size(149, 380);
            this.dgvReporteTotalNopagado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reporte Por Live";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar:";
            // 
            // txtLive
            // 
            this.txtLive.Location = new System.Drawing.Point(305, 79);
            this.txtLive.Margin = new System.Windows.Forms.Padding(1);
            this.txtLive.Name = "txtLive";
            this.txtLive.Size = new System.Drawing.Size(67, 20);
            this.txtLive.TabIndex = 10;
            this.txtLive.TextChanged += new System.EventHandler(this.txtLive_TextChanged);
            // 
            // dgvLiveTotal
            // 
            this.dgvLiveTotal.AllowUserToAddRows = false;
            this.dgvLiveTotal.AllowUserToDeleteRows = false;
            this.dgvLiveTotal.AllowUserToResizeColumns = false;
            this.dgvLiveTotal.AllowUserToResizeRows = false;
            this.dgvLiveTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLiveTotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvLiveTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLiveTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvLiveTotal.GridColor = System.Drawing.Color.White;
            this.dgvLiveTotal.Location = new System.Drawing.Point(159, 485);
            this.dgvLiveTotal.Margin = new System.Windows.Forms.Padding(1);
            this.dgvLiveTotal.MultiSelect = false;
            this.dgvLiveTotal.Name = "dgvLiveTotal";
            this.dgvLiveTotal.ReadOnly = true;
            this.dgvLiveTotal.RowHeadersVisible = false;
            this.dgvLiveTotal.RowHeadersWidth = 102;
            this.dgvLiveTotal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLiveTotal.RowTemplate.Height = 40;
            this.dgvLiveTotal.ShowEditingIcon = false;
            this.dgvLiveTotal.Size = new System.Drawing.Size(68, 53);
            this.dgvLiveTotal.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SUM(Precio)";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reporte Ventas Totales";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1206, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reporte No Pagado";
            // 
            // dgvTotalVentasTotales
            // 
            this.dgvTotalVentasTotales.AllowUserToAddRows = false;
            this.dgvTotalVentasTotales.AllowUserToDeleteRows = false;
            this.dgvTotalVentasTotales.AllowUserToResizeColumns = false;
            this.dgvTotalVentasTotales.AllowUserToResizeRows = false;
            this.dgvTotalVentasTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalVentasTotales.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotalVentasTotales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotalVentasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalVentasTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvTotalVentasTotales.GridColor = System.Drawing.Color.White;
            this.dgvTotalVentasTotales.Location = new System.Drawing.Point(635, 485);
            this.dgvTotalVentasTotales.Margin = new System.Windows.Forms.Padding(1);
            this.dgvTotalVentasTotales.MultiSelect = false;
            this.dgvTotalVentasTotales.Name = "dgvTotalVentasTotales";
            this.dgvTotalVentasTotales.ReadOnly = true;
            this.dgvTotalVentasTotales.RowHeadersVisible = false;
            this.dgvTotalVentasTotales.RowHeadersWidth = 102;
            this.dgvTotalVentasTotales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTotalVentasTotales.RowTemplate.Height = 40;
            this.dgvTotalVentasTotales.ShowEditingIcon = false;
            this.dgvTotalVentasTotales.Size = new System.Drawing.Size(68, 53);
            this.dgvTotalVentasTotales.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SUM(Precio)";
            this.dataGridViewTextBoxColumn2.HeaderText = "Total:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // NombreDgvReporteLive
            // 
            this.NombreDgvReporteLive.DataPropertyName = "Nombre";
            this.NombreDgvReporteLive.HeaderText = "Nombre";
            this.NombreDgvReporteLive.Name = "NombreDgvReporteLive";
            this.NombreDgvReporteLive.ReadOnly = true;
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
            // NombreDgvReporteTotal
            // 
            this.NombreDgvReporteTotal.DataPropertyName = "Nombre";
            this.NombreDgvReporteTotal.HeaderText = "Nombre";
            this.NombreDgvReporteTotal.Name = "NombreDgvReporteTotal";
            this.NombreDgvReporteTotal.ReadOnly = true;
            // 
            // dgvTotalProducto
            // 
            this.dgvTotalProducto.DataPropertyName = "Producto";
            this.dgvTotalProducto.HeaderText = "Producto";
            this.dgvTotalProducto.MinimumWidth = 12;
            this.dgvTotalProducto.Name = "dgvTotalProducto";
            this.dgvTotalProducto.ReadOnly = true;
            // 
            // dgvTotalPrecio
            // 
            this.dgvTotalPrecio.DataPropertyName = "Precio";
            this.dgvTotalPrecio.HeaderText = "Precio";
            this.dgvTotalPrecio.MinimumWidth = 12;
            this.dgvTotalPrecio.Name = "dgvTotalPrecio";
            this.dgvTotalPrecio.ReadOnly = true;
            // 
            // NombreDgvNoPagado
            // 
            this.NombreDgvNoPagado.DataPropertyName = "Nombre";
            this.NombreDgvNoPagado.HeaderText = "Nombre";
            this.NombreDgvNoPagado.MinimumWidth = 12;
            this.NombreDgvNoPagado.Name = "NombreDgvNoPagado";
            this.NombreDgvNoPagado.ReadOnly = true;
            // 
            // TotalDgvNoPagado
            // 
            this.TotalDgvNoPagado.DataPropertyName = "Total";
            this.TotalDgvNoPagado.HeaderText = "Total";
            this.TotalDgvNoPagado.MinimumWidth = 12;
            this.TotalDgvNoPagado.Name = "TotalDgvNoPagado";
            this.TotalDgvNoPagado.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(787, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ventas Totales Por Cliente";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 615);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTotalVentasTotales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLiveTotal);
            this.Controls.Add(this.txtLive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteTotalNopagado);
            this.Controls.Add(this.dgvReporteTotal);
            this.Controls.Add(this.dgvReporteLive);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(996, 654);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.Shown += new System.EventHandler(this.FormReportes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTotalNopagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalVentasTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteLive;
        private System.Windows.Forms.DataGridView dgvReporteTotal;
        private System.Windows.Forms.DataGridView dgvReporteTotalNopagado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLive;
        private System.Windows.Forms.DataGridView dgvLiveTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTotalVentasTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgvReporteLive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Live;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgvReporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgvNoPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDgvNoPagado;
        private System.Windows.Forms.Label label5;
    }
}