namespace TIC_CEA_SYSTEM.View
{
    partial class frmHistorialIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialIncidencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrivilegio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCerradas = new System.Windows.Forms.RadioButton();
            this.rbAbiertas = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.lblSoporte = new System.Windows.Forms.Label();
            this.cbSoporte = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvHistorialIncidencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtPrivilegio);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblSoporte);
            this.panel1.Controls.Add(this.cbSoporte);
            this.panel1.Controls.Add(this.lblDepartamento);
            this.panel1.Controls.Add(this.cbDepartamento);
            this.panel1.Controls.Add(this.lblBuscarPor);
            this.panel1.Controls.Add(this.cbTipoBusqueda);
            this.panel1.Controls.Add(this.dgvHistorialIncidencias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 450);
            this.panel1.TabIndex = 2;
            // 
            // txtPrivilegio
            // 
            this.txtPrivilegio.Location = new System.Drawing.Point(883, 29);
            this.txtPrivilegio.Name = "txtPrivilegio";
            this.txtPrivilegio.Size = new System.Drawing.Size(100, 20);
            this.txtPrivilegio.TabIndex = 99;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(883, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbCerradas);
            this.panel2.Controls.Add(this.rbAbiertas);
            this.panel2.Controls.Add(this.rbTodas);
            this.panel2.Location = new System.Drawing.Point(7, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 33);
            this.panel2.TabIndex = 97;
            // 
            // rbCerradas
            // 
            this.rbCerradas.AutoSize = true;
            this.rbCerradas.Location = new System.Drawing.Point(151, 3);
            this.rbCerradas.Name = "rbCerradas";
            this.rbCerradas.Size = new System.Drawing.Size(84, 17);
            this.rbCerradas.TabIndex = 2;
            this.rbCerradas.TabStop = true;
            this.rbCerradas.Text = "CERRADAS";
            this.rbCerradas.UseVisualStyleBackColor = true;
            this.rbCerradas.CheckedChanged += new System.EventHandler(this.RbCerradas_CheckedChanged);
            // 
            // rbAbiertas
            // 
            this.rbAbiertas.AutoSize = true;
            this.rbAbiertas.Location = new System.Drawing.Point(72, 3);
            this.rbAbiertas.Name = "rbAbiertas";
            this.rbAbiertas.Size = new System.Drawing.Size(78, 17);
            this.rbAbiertas.TabIndex = 1;
            this.rbAbiertas.TabStop = true;
            this.rbAbiertas.Text = "ABIERTAS";
            this.rbAbiertas.UseVisualStyleBackColor = true;
            this.rbAbiertas.CheckedChanged += new System.EventHandler(this.RbAbiertas_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(3, 3);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(63, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "TODOS";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.RbTodas_CheckedChanged);
            // 
            // lblSoporte
            // 
            this.lblSoporte.AutoSize = true;
            this.lblSoporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporte.Location = new System.Drawing.Point(3, 79);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Size = new System.Drawing.Size(61, 19);
            this.lblSoporte.TabIndex = 93;
            this.lblSoporte.Text = "Soporte";
            // 
            // cbSoporte
            // 
            this.cbSoporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoporte.FormattingEnabled = true;
            this.cbSoporte.ItemHeight = 13;
            this.cbSoporte.Location = new System.Drawing.Point(112, 79);
            this.cbSoporte.Name = "cbSoporte";
            this.cbSoporte.Size = new System.Drawing.Size(175, 21);
            this.cbSoporte.TabIndex = 92;
            this.cbSoporte.SelectedIndexChanged += new System.EventHandler(this.CbSoporte_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(1, 80);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(105, 19);
            this.lblDepartamento.TabIndex = 91;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.ItemHeight = 13;
            this.cbDepartamento.Location = new System.Drawing.Point(112, 80);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(175, 21);
            this.cbDepartamento.TabIndex = 90;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.CbDepartamento_SelectedIndexChanged);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(3, 48);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(87, 19);
            this.lblBuscarPor.TabIndex = 89;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cbTipoBusqueda
            // 
            this.cbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBusqueda.FormattingEnabled = true;
            this.cbTipoBusqueda.ItemHeight = 13;
            this.cbTipoBusqueda.Location = new System.Drawing.Point(112, 46);
            this.cbTipoBusqueda.Name = "cbTipoBusqueda";
            this.cbTipoBusqueda.Size = new System.Drawing.Size(175, 21);
            this.cbTipoBusqueda.TabIndex = 88;
            this.cbTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.CbEstatus_SelectedIndexChanged);
            // 
            // dgvHistorialIncidencias
            // 
            this.dgvHistorialIncidencias.AllowUserToAddRows = false;
            this.dgvHistorialIncidencias.AllowUserToDeleteRows = false;
            this.dgvHistorialIncidencias.AllowUserToResizeRows = false;
            this.dgvHistorialIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialIncidencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorialIncidencias.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvHistorialIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialIncidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHistorialIncidencias.Location = new System.Drawing.Point(3, 155);
            this.dgvHistorialIncidencias.MultiSelect = false;
            this.dgvHistorialIncidencias.Name = "dgvHistorialIncidencias";
            this.dgvHistorialIncidencias.ReadOnly = true;
            this.dgvHistorialIncidencias.RowHeadersVisible = false;
            this.dgvHistorialIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialIncidencias.ShowCellErrors = false;
            this.dgvHistorialIncidencias.ShowCellToolTips = false;
            this.dgvHistorialIncidencias.ShowEditingIcon = false;
            this.dgvHistorialIncidencias.ShowRowErrors = false;
            this.dgvHistorialIncidencias.Size = new System.Drawing.Size(980, 292);
            this.dgvHistorialIncidencias.StandardTab = true;
            this.dgvHistorialIncidencias.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "HISTORIAL DE INCIDENCIAS";
            // 
            // frmHistorialIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialIncidencia";
            this.Text = "Historial Incidencia";
            this.Load += new System.EventHandler(this.FrmHistorialIncidencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialIncidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbTipoBusqueda;
        private System.Windows.Forms.DataGridView dgvHistorialIncidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoporte;
        private System.Windows.Forms.ComboBox cbSoporte;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbCerradas;
        private System.Windows.Forms.RadioButton rbAbiertas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.TextBox txtPrivilegio;
        private System.Windows.Forms.TextBox txtNombre;
    }
}