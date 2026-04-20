namespace pryLP2VargasTP3
{
    partial class frmListadoClientes
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
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblDeuda2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gpbConsultaDatos.Controls.Add(this.label2);
            this.gpbConsultaDatos.Controls.Add(this.lblTotalClientes);
            this.gpbConsultaDatos.Controls.Add(this.label1);
            this.gpbConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gpbConsultaDatos.Controls.Add(this.lblDeuda2);
            this.gpbConsultaDatos.Controls.Add(this.dgvClientes);
            this.gpbConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(502, 447);
            this.gpbConsultaDatos.TabIndex = 2;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de datos";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Location = new System.Drawing.Point(352, 310);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(130, 23);
            this.lblTotalDeuda.TabIndex = 3;
            // 
            // lblDeuda2
            // 
            this.lblDeuda2.AutoSize = true;
            this.lblDeuda2.Location = new System.Drawing.Point(254, 311);
            this.lblDeuda2.Name = "lblDeuda2";
            this.lblDeuda2.Size = new System.Drawing.Size(92, 15);
            this.lblDeuda2.TabIndex = 2;
            this.lblDeuda2.Text = "Total de deuda:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colUsuario,
            this.colDeuda,
            this.colLimite});
            this.dgvClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(490, 266);
            this.dgvClientes.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.ReadOnly = true;
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de crédito";
            this.colLimite.Name = "colLimite";
            this.colLimite.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de clientes:";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalClientes.Location = new System.Drawing.Point(352, 349);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(130, 23);
            this.lblTotalClientes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio de deuda:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(352, 392);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(130, 23);
            this.lblPromedioDeuda.TabIndex = 7;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 471);
            this.Controls.Add(this.gpbConsultaDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblDeuda2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label label1;
    }
}