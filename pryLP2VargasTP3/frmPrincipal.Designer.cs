namespace pryLP2VargasTP3
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblDeuda2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDatos.SuspendLayout();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.btnCargar);
            this.gpbDatos.Controls.Add(this.txtLimite);
            this.gpbDatos.Controls.Add(this.lblCredito);
            this.gpbDatos.Controls.Add(this.txtUsuario);
            this.gpbDatos.Controls.Add(this.lblUsuario);
            this.gpbDatos.Controls.Add(this.txtDeuda);
            this.gpbDatos.Controls.Add(this.lblDeuda);
            this.gpbDatos.Controls.Add(this.txtCodigo);
            this.gpbDatos.Controls.Add(this.lblCodigo);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(12, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(502, 167);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Carga de datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Enabled = false;
            this.btnCargar.Location = new System.Drawing.Point(330, 129);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 32);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(330, 71);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 21);
            this.txtLimite.TabIndex = 7;
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(226, 77);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(101, 15);
            this.lblCredito.TabIndex = 6;
            this.lblCredito.Text = "Límite de crédito:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(330, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 21);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(271, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(57, 76);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(114, 21);
            this.txtDeuda.TabIndex = 3;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(9, 79);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(47, 15);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(57, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 21);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.btnListar);
            this.gpbConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gpbConsultaDatos.Controls.Add(this.lblDeuda2);
            this.gpbConsultaDatos.Controls.Add(this.dgvClientes);
            this.gpbConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsultaDatos.Location = new System.Drawing.Point(12, 202);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(502, 377);
            this.gpbConsultaDatos.TabIndex = 1;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de datos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(369, 347);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 24);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de crédito";
            this.colLimite.Name = "colLimite";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 591);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Controls.Add(this.gpbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clientes";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.Label lblDeuda2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
    }
}

