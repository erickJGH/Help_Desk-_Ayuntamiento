namespace TIC_CEA_SYSTEM.View
{
    partial class frmVerInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeparamento = new System.Windows.Forms.ComboBox();
            this.btnActualizarDatos = new System.Windows.Forms.PictureBox();
            this.dgvRemoto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbDeparamento);
            this.panel1.Controls.Add(this.btnActualizarDatos);
            this.panel1.Controls.Add(this.dgvRemoto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 424);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "DEPARTAMENTO:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbCantidad);
            this.panel2.Controls.Add(this.rbTodas);
            this.panel2.Location = new System.Drawing.Point(568, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 29);
            this.panel2.TabIndex = 90;
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Location = new System.Drawing.Point(108, 6);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(80, 17);
            this.rbCantidad.TabIndex = 3;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "CANTIDAD";
            this.rbCantidad.UseVisualStyleBackColor = true;
            this.rbCantidad.CheckedChanged += new System.EventHandler(this.RbCantidad_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(3, 7);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(63, 17);
            this.rbTodas.TabIndex = 2;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "TODOS";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.RbTodas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "ESTATUD:";
            // 
            // cbDeparamento
            // 
            this.cbDeparamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeparamento.FormattingEnabled = true;
            this.cbDeparamento.ItemHeight = 13;
            this.cbDeparamento.Location = new System.Drawing.Point(568, 107);
            this.cbDeparamento.Name = "cbDeparamento";
            this.cbDeparamento.Size = new System.Drawing.Size(197, 21);
            this.cbDeparamento.TabIndex = 88;
            this.cbDeparamento.SelectedIndexChanged += new System.EventHandler(this.CbEstatus_SelectedIndexChanged);
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.BackColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Image = global::TIC_CEA_SYSTEM.Properties.Resources.refresh_update_15608;
            this.btnActualizarDatos.Location = new System.Drawing.Point(265, 157);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(74, 36);
            this.btnActualizarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnActualizarDatos.TabIndex = 43;
            this.btnActualizarDatos.TabStop = false;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // dgvRemoto
            // 
            this.dgvRemoto.AllowUserToAddRows = false;
            this.dgvRemoto.AllowUserToDeleteRows = false;
            this.dgvRemoto.AllowUserToResizeRows = false;
            this.dgvRemoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRemoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRemoto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRemoto.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvRemoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRemoto.Location = new System.Drawing.Point(3, 198);
            this.dgvRemoto.MultiSelect = false;
            this.dgvRemoto.Name = "dgvRemoto";
            this.dgvRemoto.ReadOnly = true;
            this.dgvRemoto.RowHeadersVisible = false;
            this.dgvRemoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemoto.ShowCellErrors = false;
            this.dgvRemoto.ShowCellToolTips = false;
            this.dgvRemoto.ShowEditingIcon = false;
            this.dgvRemoto.ShowRowErrors = false;
            this.dgvRemoto.Size = new System.Drawing.Size(762, 223);
            this.dgvRemoto.StandardTab = true;
            this.dgvRemoto.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "EQUIPO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "VER INVENTARIO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmVerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 424);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerInventario";
            this.Text = "Ver Inventario";
            this.Load += new System.EventHandler(this.frmVerRemoto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvRemoto;
        private System.Windows.Forms.PictureBox btnActualizarDatos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDeparamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbCantidad;
    }
}