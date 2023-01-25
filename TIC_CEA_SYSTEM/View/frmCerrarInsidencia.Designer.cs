namespace TIC_CEA_SYSTEM.View
{
    partial class frmCerrarInsidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerrarInsidencia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSoporte = new System.Windows.Forms.TextBox();
            this.txtSoluccionTicket = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnActualizarDatos = new System.Windows.Forms.PictureBox();
            this.rbSiPieza = new System.Windows.Forms.RadioButton();
            this.cbPiezas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCerrarIncidencia = new System.Windows.Forms.DataGridView();
            this.btnCancelarSoluccion = new System.Windows.Forms.PictureBox();
            this.btnGuardarSoluccion = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroTicket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Incidencia = new System.Windows.Forms.NotifyIcon(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNoPieza = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbNoColaborador = new System.Windows.Forms.RadioButton();
            this.rbSiColaborador = new System.Windows.Forms.RadioButton();
            this.cbSoporteColaborador = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerrarIncidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarSoluccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarSoluccion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbSoporteColaborador);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtSoporte);
            this.panel2.Controls.Add(this.txtSoluccionTicket);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnActualizarDatos);
            this.panel2.Controls.Add(this.cbPiezas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvCerrarIncidencia);
            this.panel2.Controls.Add(this.btnCancelarSoluccion);
            this.panel2.Controls.Add(this.btnGuardarSoluccion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumeroTicket);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 644);
            this.panel2.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombre.Location = new System.Drawing.Point(729, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 20);
            this.txtNombre.TabIndex = 82;
            // 
            // txtSoporte
            // 
            this.txtSoporte.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoporte.Location = new System.Drawing.Point(729, 3);
            this.txtSoporte.Name = "txtSoporte";
            this.txtSoporte.Size = new System.Drawing.Size(109, 20);
            this.txtSoporte.TabIndex = 81;
            // 
            // txtSoluccionTicket
            // 
            this.txtSoluccionTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoluccionTicket.Location = new System.Drawing.Point(169, 133);
            this.txtSoluccionTicket.Multiline = true;
            this.txtSoluccionTicket.Name = "txtSoluccionTicket";
            this.txtSoluccionTicket.Size = new System.Drawing.Size(306, 94);
            this.txtSoluccionTicket.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "BUSCAR DEPARTAMENTO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 78;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Image = global::TIC_CEA_SYSTEM.Properties.Resources.refresh_update_15608;
            this.btnActualizarDatos.Location = new System.Drawing.Point(169, 410);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(74, 40);
            this.btnActualizarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnActualizarDatos.TabIndex = 76;
            this.btnActualizarDatos.TabStop = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // rbSiPieza
            // 
            this.rbSiPieza.AutoSize = true;
            this.rbSiPieza.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSiPieza.Location = new System.Drawing.Point(0, 3);
            this.rbSiPieza.Name = "rbSiPieza";
            this.rbSiPieza.Size = new System.Drawing.Size(37, 19);
            this.rbSiPieza.TabIndex = 51;
            this.rbSiPieza.TabStop = true;
            this.rbSiPieza.Text = "SI";
            this.rbSiPieza.UseVisualStyleBackColor = true;
            this.rbSiPieza.CheckedChanged += new System.EventHandler(this.rbConfirmacion_CheckedChanged);
            // 
            // cbPiezas
            // 
            this.cbPiezas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiezas.FormattingEnabled = true;
            this.cbPiezas.Location = new System.Drawing.Point(311, 253);
            this.cbPiezas.Name = "cbPiezas";
            this.cbPiezas.Size = new System.Drawing.Size(164, 21);
            this.cbPiezas.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "CAMBIO DE PIEZA:";
            // 
            // dgvCerrarIncidencia
            // 
            this.dgvCerrarIncidencia.AllowUserToAddRows = false;
            this.dgvCerrarIncidencia.AllowUserToDeleteRows = false;
            this.dgvCerrarIncidencia.AllowUserToResizeColumns = false;
            this.dgvCerrarIncidencia.AllowUserToResizeRows = false;
            this.dgvCerrarIncidencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCerrarIncidencia.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCerrarIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerrarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCerrarIncidencia.Location = new System.Drawing.Point(3, 456);
            this.dgvCerrarIncidencia.MultiSelect = false;
            this.dgvCerrarIncidencia.Name = "dgvCerrarIncidencia";
            this.dgvCerrarIncidencia.ReadOnly = true;
            this.dgvCerrarIncidencia.RowHeadersVisible = false;
            this.dgvCerrarIncidencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCerrarIncidencia.ShowCellErrors = false;
            this.dgvCerrarIncidencia.ShowCellToolTips = false;
            this.dgvCerrarIncidencia.ShowEditingIcon = false;
            this.dgvCerrarIncidencia.ShowRowErrors = false;
            this.dgvCerrarIncidencia.Size = new System.Drawing.Size(835, 185);
            this.dgvCerrarIncidencia.StandardTab = true;
            this.dgvCerrarIncidencia.TabIndex = 47;
            this.dgvCerrarIncidencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCerrarIncidencia_CellClick);
            this.dgvCerrarIncidencia.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvCerrarIncidencia_RowsAdded);
            // 
            // btnCancelarSoluccion
            // 
            this.btnCancelarSoluccion.BackColor = System.Drawing.Color.White;
            this.btnCancelarSoluccion.Image = global::TIC_CEA_SYSTEM.Properties.Resources.cancelar;
            this.btnCancelarSoluccion.Location = new System.Drawing.Point(767, 400);
            this.btnCancelarSoluccion.Name = "btnCancelarSoluccion";
            this.btnCancelarSoluccion.Size = new System.Drawing.Size(62, 50);
            this.btnCancelarSoluccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCancelarSoluccion.TabIndex = 8;
            this.btnCancelarSoluccion.TabStop = false;
            this.btnCancelarSoluccion.Click += new System.EventHandler(this.btnCancelarSoluccion_Click);
            // 
            // btnGuardarSoluccion
            // 
            this.btnGuardarSoluccion.BackColor = System.Drawing.Color.White;
            this.btnGuardarSoluccion.Image = global::TIC_CEA_SYSTEM.Properties.Resources.guardar;
            this.btnGuardarSoluccion.Location = new System.Drawing.Point(699, 400);
            this.btnGuardarSoluccion.Name = "btnGuardarSoluccion";
            this.btnGuardarSoluccion.Size = new System.Drawing.Size(62, 50);
            this.btnGuardarSoluccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGuardarSoluccion.TabIndex = 7;
            this.btnGuardarSoluccion.TabStop = false;
            this.btnGuardarSoluccion.Click += new System.EventHandler(this.btnGuardarSoluccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "NO. TICKET:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOLUCION INCIDENCIA:";
            // 
            // txtNumeroTicket
            // 
            this.txtNumeroTicket.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroTicket.Location = new System.Drawing.Point(169, 82);
            this.txtNumeroTicket.Name = "txtNumeroTicket";
            this.txtNumeroTicket.Size = new System.Drawing.Size(147, 20);
            this.txtNumeroTicket.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CERRAR INCIDENCIA";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Incidencia
            // 
            this.Incidencia.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Incidencia.BalloonTipText = "Porfavor entre a revisar sus incidencias";
            this.Incidencia.BalloonTipTitle = "Nueva Incidencia";
            this.Incidencia.Icon = ((System.Drawing.Icon)(resources.GetObject("Incidencia.Icon")));
            this.Incidencia.Text = "notifyIcon1";
            this.Incidencia.Visible = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "COLABORACION:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNoPieza);
            this.panel1.Controls.Add(this.rbSiPieza);
            this.panel1.Location = new System.Drawing.Point(169, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 24);
            this.panel1.TabIndex = 84;
            // 
            // rbNoPieza
            // 
            this.rbNoPieza.AutoSize = true;
            this.rbNoPieza.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoPieza.Location = new System.Drawing.Point(52, 3);
            this.rbNoPieza.Name = "rbNoPieza";
            this.rbNoPieza.Size = new System.Drawing.Size(44, 19);
            this.rbNoPieza.TabIndex = 52;
            this.rbNoPieza.TabStop = true;
            this.rbNoPieza.Text = "NO";
            this.rbNoPieza.UseVisualStyleBackColor = true;
            this.rbNoPieza.CheckedChanged += new System.EventHandler(this.RbNoPieza_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbNoColaborador);
            this.panel3.Controls.Add(this.rbSiColaborador);
            this.panel3.Location = new System.Drawing.Point(169, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 24);
            this.panel3.TabIndex = 86;
            // 
            // rbNoColaborador
            // 
            this.rbNoColaborador.AutoSize = true;
            this.rbNoColaborador.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoColaborador.Location = new System.Drawing.Point(52, 3);
            this.rbNoColaborador.Name = "rbNoColaborador";
            this.rbNoColaborador.Size = new System.Drawing.Size(44, 19);
            this.rbNoColaborador.TabIndex = 52;
            this.rbNoColaborador.TabStop = true;
            this.rbNoColaborador.Text = "NO";
            this.rbNoColaborador.UseVisualStyleBackColor = true;
            this.rbNoColaborador.CheckedChanged += new System.EventHandler(this.RbNoColaborador_CheckedChanged);
            // 
            // rbSiColaborador
            // 
            this.rbSiColaborador.AutoSize = true;
            this.rbSiColaborador.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSiColaborador.Location = new System.Drawing.Point(0, 3);
            this.rbSiColaborador.Name = "rbSiColaborador";
            this.rbSiColaborador.Size = new System.Drawing.Size(37, 19);
            this.rbSiColaborador.TabIndex = 51;
            this.rbSiColaborador.TabStop = true;
            this.rbSiColaborador.Text = "SI";
            this.rbSiColaborador.UseVisualStyleBackColor = true;
            this.rbSiColaborador.CheckedChanged += new System.EventHandler(this.RbSiColaborador_CheckedChanged);
            // 
            // cbSoporteColaborador
            // 
            this.cbSoporteColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoporteColaborador.FormattingEnabled = true;
            this.cbSoporteColaborador.Location = new System.Drawing.Point(311, 303);
            this.cbSoporteColaborador.Name = "cbSoporteColaborador";
            this.cbSoporteColaborador.Size = new System.Drawing.Size(164, 21);
            this.cbSoporteColaborador.TabIndex = 85;
            // 
            // frmCerrarInsidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(841, 644);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCerrarInsidencia";
            this.Text = "Cerrar Incidencia";
            this.Load += new System.EventHandler(this.frmCerrarInsidencia_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerrarIncidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarSoluccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarSoluccion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCancelarSoluccion;
        private System.Windows.Forms.PictureBox btnGuardarSoluccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroTicket;
        private System.Windows.Forms.DataGridView dgvCerrarIncidencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPiezas;
        private System.Windows.Forms.RadioButton rbSiPieza;
        private System.Windows.Forms.PictureBox btnActualizarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSoluccionTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSoporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NotifyIcon Incidencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNoPieza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbNoColaborador;
        private System.Windows.Forms.RadioButton rbSiColaborador;
        private System.Windows.Forms.ComboBox cbSoporteColaborador;
    }
}