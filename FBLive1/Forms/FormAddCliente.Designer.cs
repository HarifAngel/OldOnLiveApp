namespace FBLive1.Forms
{
    partial class FormAddCliente
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(124, 153);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(122, 32);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 200);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(309, 38);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardarAgregarCliente
            // 
            this.btnGuardarAgregarCliente.Location = new System.Drawing.Point(191, 300);
            this.btnGuardarAgregarCliente.Name = "btnGuardarAgregarCliente";
            this.btnGuardarAgregarCliente.Size = new System.Drawing.Size(184, 79);
            this.btnGuardarAgregarCliente.TabIndex = 2;
            this.btnGuardarAgregarCliente.Text = "Guardar";
            this.btnGuardarAgregarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarAgregarCliente.Click += new System.EventHandler(this.btnGuardarAgregarCliente_Click);
            // 
            // FormAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 599);
            this.Controls.Add(this.btnGuardarAgregarCliente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAddCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardarAgregarCliente;
    }
}