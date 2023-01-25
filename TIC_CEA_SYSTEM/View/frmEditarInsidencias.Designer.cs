namespace TIC_CEA_SYSTEM.View
{
    partial class frmEditarInsidencias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarInsidencias));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizarDatos = new System.Windows.Forms.PictureBox();
            this.cbComponenteEquipoConfig = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoConfig = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoriaConfig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExtensionTelefonoConfig = new System.Windows.Forms.TextBox();
            this.cbSoporteConfig = new System.Windows.Forms.ComboBox();
            this.txtDetalleReporteConfig = new System.Windows.Forms.TextBox();
            this.txtUsuarioReportanteCofig = new System.Windows.Forms.TextBox();
            this.cbDepartamentoConfig = new System.Windows.Forms.ComboBox();
            this.btnBorrarInsidencia = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarConfig = new System.Windows.Forms.TextBox();
            this.dgvConfigurarIncidencia = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelarInsidencia = new System.Windows.Forms.PictureBox();
            this.btnGuardarInsidencia = new System.Windows.Forms.PictureBox();
            this.txtNumeroTicketConfig = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNombreEncargado = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarInsidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurarIncidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarInsidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarInsidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txtNombreEncargado);
            this.panel2.Controls.Add(this.btnActualizarDatos);
            this.panel2.Controls.Add(this.cbComponenteEquipoConfig);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbTipoConfig);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbCategoriaConfig);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtExtensionTelefonoConfig);
            this.panel2.Controls.Add(this.cbSoporteConfig);
            this.panel2.Controls.Add(this.txtDetalleReporteConfig);
            this.panel2.Controls.Add(this.txtUsuarioReportanteCofig);
            this.panel2.Controls.Add(this.cbDepartamentoConfig);
            this.panel2.Controls.Add(this.btnBorrarInsidencia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBuscarConfig);
            this.panel2.Controls.Add(this.dgvConfigurarIncidencia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnCancelarInsidencia);
            this.panel2.Controls.Add(this.btnGuardarInsidencia);
            this.panel2.Controls.Add(this.txtNumeroTicketConfig);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 558);
            this.panel2.TabIndex = 2;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Image = global::TIC_CEA_SYSTEM.Properties.Resources.refresh_update_15608;
            this.btnActualizarDatos.Location = new System.Drawing.Point(316, 328);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(74, 36);
            this.btnActualizarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnActualizarDatos.TabIndex = 75;
            this.btnActualizarDatos.TabStop = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // cbComponenteEquipoConfig
            // 
            this.cbComponenteEquipoConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComponenteEquipoConfig.FormattingEnabled = true;
            this.cbComponenteEquipoConfig.Location = new System.Drawing.Point(669, 77);
            this.cbComponenteEquipoConfig.Name = "cbComponenteEquipoConfig";
            this.cbComponenteEquipoConfig.Size = new System.Drawing.Size(196, 21);
            this.cbComponenteEquipoConfig.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "EQUIPO/COMPONENTE:";
            // 
            // cbTipoConfig
            // 
            this.cbTipoConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoConfig.FormattingEnabled = true;
            this.cbTipoConfig.Location = new System.Drawing.Point(669, 116);
            this.cbTipoConfig.Name = "cbTipoConfig";
            this.cbTipoConfig.Size = new System.Drawing.Size(196, 21);
            this.cbTipoConfig.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "TIPO:";
            // 
            // cbCategoriaConfig
            // 
            this.cbCategoriaConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaConfig.FormattingEnabled = true;
            this.cbCategoriaConfig.Location = new System.Drawing.Point(168, 263);
            this.cbCategoriaConfig.Name = "cbCategoriaConfig";
            this.cbCategoriaConfig.Size = new System.Drawing.Size(203, 21);
            this.cbCategoriaConfig.TabIndex = 3;
            this.cbCategoriaConfig.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaConfig_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "CATEGORIA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "SOPORTE A CARGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "EXT. DEPARTAMENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "DETALLE AVERIA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "USURIO REPORTANTE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "DEPARTAMENTO:";
            // 
            // txtExtensionTelefonoConfig
            // 
            this.txtExtensionTelefonoConfig.Location = new System.Drawing.Point(669, 169);
            this.txtExtensionTelefonoConfig.Name = "txtExtensionTelefonoConfig";
            this.txtExtensionTelefonoConfig.Size = new System.Drawing.Size(196, 20);
            this.txtExtensionTelefonoConfig.TabIndex = 6;
            // 
            // cbSoporteConfig
            // 
            this.cbSoporteConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoporteConfig.FormattingEnabled = true;
            this.cbSoporteConfig.Location = new System.Drawing.Point(669, 222);
            this.cbSoporteConfig.Name = "cbSoporteConfig";
            this.cbSoporteConfig.Size = new System.Drawing.Size(196, 21);
            this.cbSoporteConfig.TabIndex = 57;
            // 
            // txtDetalleReporteConfig
            // 
            this.txtDetalleReporteConfig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalleReporteConfig.Location = new System.Drawing.Point(168, 138);
            this.txtDetalleReporteConfig.Multiline = true;
            this.txtDetalleReporteConfig.Name = "txtDetalleReporteConfig";
            this.txtDetalleReporteConfig.Size = new System.Drawing.Size(203, 107);
            this.txtDetalleReporteConfig.TabIndex = 2;
            // 
            // txtUsuarioReportanteCofig
            // 
            this.txtUsuarioReportanteCofig.Location = new System.Drawing.Point(168, 102);
            this.txtUsuarioReportanteCofig.Name = "txtUsuarioReportanteCofig";
            this.txtUsuarioReportanteCofig.Size = new System.Drawing.Size(203, 20);
            this.txtUsuarioReportanteCofig.TabIndex = 1;
            // 
            // cbDepartamentoConfig
            // 
            this.cbDepartamentoConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentoConfig.FormattingEnabled = true;
            this.cbDepartamentoConfig.Location = new System.Drawing.Point(168, 71);
            this.cbDepartamentoConfig.Name = "cbDepartamentoConfig";
            this.cbDepartamentoConfig.Size = new System.Drawing.Size(203, 21);
            this.cbDepartamentoConfig.TabIndex = 0;
            // 
            // btnBorrarInsidencia
            // 
            this.btnBorrarInsidencia.BackColor = System.Drawing.Color.White;
            this.btnBorrarInsidencia.Image = global::TIC_CEA_SYSTEM.Properties.Resources.borrar;
            this.btnBorrarInsidencia.Location = new System.Drawing.Point(652, 328);
            this.btnBorrarInsidencia.Name = "btnBorrarInsidencia";
            this.btnBorrarInsidencia.Size = new System.Drawing.Size(74, 36);
            this.btnBorrarInsidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBorrarInsidencia.TabIndex = 49;
            this.btnBorrarInsidencia.TabStop = false;
            this.btnBorrarInsidencia.Click += new System.EventHandler(this.btnBorrarInsidencia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "BUSCAR SOPORTE:";
            // 
            // txtBuscarConfig
            // 
            this.txtBuscarConfig.Location = new System.Drawing.Point(135, 341);
            this.txtBuscarConfig.Name = "txtBuscarConfig";
            this.txtBuscarConfig.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarConfig.TabIndex = 47;
            this.txtBuscarConfig.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dgvConfigurarIncidencia
            // 
            this.dgvConfigurarIncidencia.AllowUserToAddRows = false;
            this.dgvConfigurarIncidencia.AllowUserToDeleteRows = false;
            this.dgvConfigurarIncidencia.AllowUserToResizeRows = false;
            this.dgvConfigurarIncidencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConfigurarIncidencia.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvConfigurarIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigurarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConfigurarIncidencia.Location = new System.Drawing.Point(3, 370);
            this.dgvConfigurarIncidencia.MultiSelect = false;
            this.dgvConfigurarIncidencia.Name = "dgvConfigurarIncidencia";
            this.dgvConfigurarIncidencia.ReadOnly = true;
            this.dgvConfigurarIncidencia.RowHeadersVisible = false;
            this.dgvConfigurarIncidencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfigurarIncidencia.ShowCellErrors = false;
            this.dgvConfigurarIncidencia.ShowCellToolTips = false;
            this.dgvConfigurarIncidencia.ShowEditingIcon = false;
            this.dgvConfigurarIncidencia.ShowRowErrors = false;
            this.dgvConfigurarIncidencia.Size = new System.Drawing.Size(909, 185);
            this.dgvConfigurarIncidencia.StandardTab = true;
            this.dgvConfigurarIncidencia.TabIndex = 46;
            this.dgvConfigurarIncidencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfigurarIncidencia_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "CONFIGURAR INCIDENCIAS";
            // 
            // btnCancelarInsidencia
            // 
            this.btnCancelarInsidencia.BackColor = System.Drawing.Color.White;
            this.btnCancelarInsidencia.Image = global::TIC_CEA_SYSTEM.Properties.Resources.cancelar;
            this.btnCancelarInsidencia.Location = new System.Drawing.Point(829, 328);
            this.btnCancelarInsidencia.Name = "btnCancelarInsidencia";
            this.btnCancelarInsidencia.Size = new System.Drawing.Size(74, 36);
            this.btnCancelarInsidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCancelarInsidencia.TabIndex = 36;
            this.btnCancelarInsidencia.TabStop = false;
            this.btnCancelarInsidencia.Click += new System.EventHandler(this.btnCancelarInsidencia_Click);
            // 
            // btnGuardarInsidencia
            // 
            this.btnGuardarInsidencia.BackColor = System.Drawing.Color.White;
            this.btnGuardarInsidencia.Image = global::TIC_CEA_SYSTEM.Properties.Resources.guardar;
            this.btnGuardarInsidencia.Location = new System.Drawing.Point(742, 328);
            this.btnGuardarInsidencia.Name = "btnGuardarInsidencia";
            this.btnGuardarInsidencia.Size = new System.Drawing.Size(74, 36);
            this.btnGuardarInsidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGuardarInsidencia.TabIndex = 35;
            this.btnGuardarInsidencia.TabStop = false;
            this.btnGuardarInsidencia.Click += new System.EventHandler(this.btnGuardarInsidencia_Click);
            // 
            // txtNumeroTicketConfig
            // 
            this.txtNumeroTicketConfig.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroTicketConfig.Location = new System.Drawing.Point(107, 32);
            this.txtNumeroTicketConfig.Name = "txtNumeroTicketConfig";
            this.txtNumeroTicketConfig.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroTicketConfig.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "NO. TICKET:";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtNombreEncargado
            // 
            this.txtNombreEncargado.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreEncargado.Location = new System.Drawing.Point(862, 3);
            this.txtNombreEncargado.Name = "txtNombreEncargado";
            this.txtNombreEncargado.Size = new System.Drawing.Size(50, 20);
            this.txtNombreEncargado.TabIndex = 76;
            // 
            // frmEditarInsidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(915, 558);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarInsidencias";
            this.Text = "Configurar Incidencias";
            this.Load += new System.EventHandler(this.frmConfigurarInsidencias_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarInsidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurarIncidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarInsidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarInsidencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnCancelarInsidencia;
        private System.Windows.Forms.PictureBox btnGuardarInsidencia;
        private System.Windows.Forms.TextBox txtNumeroTicketConfig;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarConfig;
        private System.Windows.Forms.PictureBox btnBorrarInsidencia;
        private System.Windows.Forms.DataGridView dgvConfigurarIncidencia;
        private System.Windows.Forms.ComboBox cbComponenteEquipoConfig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategoriaConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExtensionTelefonoConfig;
        public System.Windows.Forms.ComboBox cbSoporteConfig;
        private System.Windows.Forms.TextBox txtDetalleReporteConfig;
        private System.Windows.Forms.TextBox txtUsuarioReportanteCofig;
        public System.Windows.Forms.ComboBox cbDepartamentoConfig;
        private System.Windows.Forms.PictureBox btnActualizarDatos;
        public System.Windows.Forms.ComboBox cbTipoConfig;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtNombreEncargado;
    }
}