namespace TIC_CEA_SYSTEM.View
{
    partial class frmEditarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarInventario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDetalleEquipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroInventarido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarDatos = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarConfig = new System.Windows.Forms.TextBox();
            this.dgvConfigurarRemoto = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.txtIdInventario = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurarRemoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txtDetalleEquipo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtModelo);
            this.panel2.Controls.Add(this.cbEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNumeroInventarido);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbEquipo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActualizarDatos);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBuscarConfig);
            this.panel2.Controls.Add(this.dgvConfigurarRemoto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtIdInventario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 609);
            this.panel2.TabIndex = 3;
            // 
            // txtDetalleEquipo
            // 
            this.txtDetalleEquipo.Location = new System.Drawing.Point(569, 217);
            this.txtDetalleEquipo.MaxLength = 200;
            this.txtDetalleEquipo.Multiline = true;
            this.txtDetalleEquipo.Name = "txtDetalleEquipo";
            this.txtDetalleEquipo.Size = new System.Drawing.Size(175, 127);
            this.txtDetalleEquipo.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "DETALLES DEL EQUIPO:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(569, 82);
            this.txtModelo.MaxLength = 25;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(175, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ItemHeight = 13;
            this.cbEstado.Location = new System.Drawing.Point(569, 155);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(175, 21);
            this.cbEstado.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "ESTADO DEL EQUIPO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "MODELO DE EQUIPO:";
            // 
            // txtNumeroInventarido
            // 
            this.txtNumeroInventarido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroInventarido.Location = new System.Drawing.Point(196, 87);
            this.txtNumeroInventarido.MaxLength = 9;
            this.txtNumeroInventarido.Name = "txtNumeroInventarido";
            this.txtNumeroInventarido.Size = new System.Drawing.Size(175, 20);
            this.txtNumeroInventarido.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "NUMERO DE INVENTARIADO:";
            // 
            // cbEquipo
            // 
            this.cbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(196, 150);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(175, 21);
            this.cbEquipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "TIPO DE EQUIPO:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(196, 212);
            this.txtMarca.MaxLength = 25;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(175, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "MARCA DE EQUIPO:";
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Image = global::TIC_CEA_SYSTEM.Properties.Resources.refresh_update_15608;
            this.btnActualizarDatos.Location = new System.Drawing.Point(266, 369);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(74, 36);
            this.btnActualizarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnActualizarDatos.TabIndex = 75;
            this.btnActualizarDatos.TabStop = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::TIC_CEA_SYSTEM.Properties.Resources.borrar;
            this.btnDelete.Location = new System.Drawing.Point(569, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 36);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDelete.TabIndex = 49;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "BUSCAR EQUIPO:";
            // 
            // txtBuscarConfig
            // 
            this.txtBuscarConfig.Location = new System.Drawing.Point(123, 385);
            this.txtBuscarConfig.Name = "txtBuscarConfig";
            this.txtBuscarConfig.Size = new System.Drawing.Size(137, 20);
            this.txtBuscarConfig.TabIndex = 47;
            this.txtBuscarConfig.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarConfig_KeyUp);
            // 
            // dgvConfigurarRemoto
            // 
            this.dgvConfigurarRemoto.AllowUserToAddRows = false;
            this.dgvConfigurarRemoto.AllowUserToDeleteRows = false;
            this.dgvConfigurarRemoto.AllowUserToResizeRows = false;
            this.dgvConfigurarRemoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfigurarRemoto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConfigurarRemoto.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvConfigurarRemoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigurarRemoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConfigurarRemoto.Location = new System.Drawing.Point(3, 411);
            this.dgvConfigurarRemoto.MultiSelect = false;
            this.dgvConfigurarRemoto.Name = "dgvConfigurarRemoto";
            this.dgvConfigurarRemoto.ReadOnly = true;
            this.dgvConfigurarRemoto.RowHeadersVisible = false;
            this.dgvConfigurarRemoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfigurarRemoto.ShowCellErrors = false;
            this.dgvConfigurarRemoto.ShowCellToolTips = false;
            this.dgvConfigurarRemoto.ShowEditingIcon = false;
            this.dgvConfigurarRemoto.ShowRowErrors = false;
            this.dgvConfigurarRemoto.Size = new System.Drawing.Size(741, 195);
            this.dgvConfigurarRemoto.StandardTab = true;
            this.dgvConfigurarRemoto.TabIndex = 46;
            this.dgvConfigurarRemoto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfigurarRemoto_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "CONFIGURAR INVENTARIO";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::TIC_CEA_SYSTEM.Properties.Resources.cancelar;
            this.btnCancel.Location = new System.Drawing.Point(670, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 36);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCancel.TabIndex = 36;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::TIC_CEA_SYSTEM.Properties.Resources.guardar;
            this.btnSave.Location = new System.Drawing.Point(475, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 36);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSave.TabIndex = 35;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIdInventario
            // 
            this.txtIdInventario.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdInventario.Location = new System.Drawing.Point(6, 9);
            this.txtIdInventario.Name = "txtIdInventario";
            this.txtIdInventario.Size = new System.Drawing.Size(50, 20);
            this.txtIdInventario.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmEditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 609);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarInventario";
            this.Text = "Configurar Inventario";
            this.Load += new System.EventHandler(this.frmEditarRemoto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurarRemoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnActualizarDatos;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarConfig;
        private System.Windows.Forms.DataGridView dgvConfigurarRemoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.TextBox txtIdInventario;
        private System.Windows.Forms.TextBox txtNumeroInventarido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetalleEquipo;
    }
}