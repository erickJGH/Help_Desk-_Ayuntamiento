using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TIC_CEA_SYSTEM.View
{
    public partial class Main : Form    
    {
        //manage of window
        int LX, LY;
        public string PRIVILEGIO;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwd, int wsg, int wparam, int Imparam);

        //formularios
        frmAgregarInsidencia FormAgregarIncidencias;
        frmEditarInsidencias FormEditarInsidencias;
        frmCerrarInsidencia FormCerrarInsidencia;
        frmHistorialIncidencia FormHistorialIncidencia;
        frmAgregarUsuario FormAgregarUsuario;
        frmEditarUsuario FormEditarUsuario;
        frmCambiarPassword FormCambiarPassword;
        frmAgregarInventario FormAgregarInventario;
        frmEditarInventario FormEditarInventario;
        frmVerInventario FormVerInventario;        

        void FormAgregarIncidencias_closed(object sender,EventArgs e)
        {
            FormAgregarIncidencias = null;            
        }
        void FormEditarInsidencias_closed(object sender, EventArgs e)
        {
            FormEditarInsidencias = null;
        }
        void FormCerrarInsidencia_closed(object sender, EventArgs e)
        {
            FormCerrarInsidencia = null;
        }
        void FormHistorialIncidencia_closed(object sender, EventArgs e)
        {
            FormHistorialIncidencia = null;
        }
        void FormAgregarUsuario_closed(object sender, EventArgs e)
        {
            FormAgregarUsuario = null;
        }
        void FormEditarUsuario_closed(object sender, EventArgs e)
        {
            FormEditarUsuario = null;
        }
        void FormCambiarPassword_closed(object sender, EventArgs e)
        {
            FormCambiarPassword = null;
        }
        void FormAgregarInventario_closed(object sender, EventArgs e)
        {
            FormAgregarInventario = null;
        }
        void FormEditarInventario_closed(object sender, EventArgs e)
        {
            FormEditarInventario = null;
        }
        void FormVerInventario_closed(object sender, EventArgs e)
        {
            FormVerInventario = null;
        }
        
        public Main()
        {
            InitializeComponent();            
            txtUsuario.Enabled = false;
            txtPrivilegio.Enabled = false;            
            txtNombre.Visible = false;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;            

        }
        private void Main_Load(object sender, EventArgs e)
        {

            if (txtPrivilegio.Text == "ENCARGADO/A")
            {                                                               
                //botones
                btnCerrarInsidencias.Visible = false;
            }
            else if (txtPrivilegio.Text == "SOPORTE")
            {
                //menus
                btnMantenimiento.Visible = true;
                btnInventario.Visible = false;                            
                //botones
                btnAbrirInsidencias.Visible = false;
                btnConfigurarInsidencia.Visible = false;

                btnAgregarUsuario.Visible = false;
                btnEditarUsuario.Visible = false;
                btnHistorialInsidencia.Visible = true;

            }
            else if (txtPrivilegio.Text == "INCIDENCIAS")
            {
                //menus
                btnMantenimiento.Visible = false;
                btnInventario.Visible = false;                
                btnInsidencias.Visible = true;
                //botones
                btnHistorialInsidencia.Visible = false;
                btnCerrarInsidencias.Visible = false;
            }
            else if (txtPrivilegio.Text == "INVENTARIO")
            {
                //menus
                btnMantenimiento.Visible = false;
                btnInventario.Visible = true;               
                btnInsidencias.Visible = false;
                //botones
                btnHistorialInsidencia.Visible = false;
                btnCerrarInsidencias.Visible = false;
            }            
        }
               
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;            
            
        }        
        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1044, 580);
            this.Location = new Point(LX, LY);               
           
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;            
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Size.Width == 1044 && this.Size.Height == 580)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }                                   
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //button insidents
        private void btnInsidencias_Click(object sender, EventArgs e)
        {                      
            if (subMenuInsidencias.Visible == true)
            {
                subMenuInsidencias.Visible = false;
                subMenuMantenimiento.Visible = false;                
                SubMenuInventario.Visible = false;                
            }
            else
            {
                subMenuInsidencias.Visible = true;
                subMenuMantenimiento.Visible = false;                
                SubMenuInventario.Visible = false;               
            }
        }        
        private void btnAbrirInsidencias_Click(object sender, EventArgs e)
        {
            subMenuInsidencias.Visible = false;
            if (FormAgregarIncidencias == null)
            {
                FormAgregarIncidencias = new frmAgregarInsidencia(txtUsuario.Text, txtNombre.Text);
                FormAgregarIncidencias.MdiParent = this;
                FormAgregarIncidencias.FormClosed += new FormClosedEventHandler(FormAgregarIncidencias_closed);
                FormAgregarIncidencias.Show();
            }
        }
        private void btnConfigurarInsidencia_Click(object sender, EventArgs e)
        {
            subMenuInsidencias.Visible = false;
            if (FormEditarInsidencias == null)
            {
                FormEditarInsidencias = new frmEditarInsidencias(txtUsuario.Text);
                FormEditarInsidencias.MdiParent = this;
                FormEditarInsidencias.FormClosed += new FormClosedEventHandler(FormEditarInsidencias_closed);
                FormEditarInsidencias.Show();
            }                                 
        }
        private void btnCerrarInsidencias_Click(object sender, EventArgs e)
        {            
            subMenuInsidencias.Visible = false;
            if (FormCerrarInsidencia == null)
            {
                FormCerrarInsidencia = new frmCerrarInsidencia(txtNombre.Text, txtPrivilegio.Text);
                FormCerrarInsidencia.MdiParent = this;
                FormCerrarInsidencia.FormClosed += new FormClosedEventHandler(FormCerrarInsidencia_closed);
                FormCerrarInsidencia.Show();
            }                    
        }
        private void BtnHistorialInsidencia_Click(object sender, EventArgs e)
        {
            subMenuInsidencias.Visible = false;
            if (FormHistorialIncidencia == null)
            {
                FormHistorialIncidencia = new frmHistorialIncidencia(txtNombre.Text, txtPrivilegio.Text);
                FormHistorialIncidencia.MdiParent = this;
                FormHistorialIncidencia.FormClosed += new FormClosedEventHandler(FormHistorialIncidencia_closed);
                FormHistorialIncidencia.Show();
            }            
        }
        
        //button mantenimiento
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (subMenuMantenimiento.Visible == true)
            {
                subMenuInsidencias.Visible = false;
                subMenuMantenimiento.Visible = false;                
                SubMenuInventario.Visible = false;                
            }
            else
            {
                subMenuInsidencias.Visible = false;
                subMenuMantenimiento.Visible = true;
                SubMenuInventario.Visible = false;                                
            }
        }        
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            subMenuMantenimiento.Visible = false;
            if (FormAgregarUsuario == null)
            {
                FormAgregarUsuario = new frmAgregarUsuario(txtPrivilegio.Text);
                FormAgregarUsuario.MdiParent = this;
                FormAgregarUsuario.FormClosed += new FormClosedEventHandler(FormAgregarUsuario_closed);
                FormAgregarUsuario.Show();
            }                       
        }
        private void button2_Click(object sender, EventArgs e)
        {
            subMenuMantenimiento.Visible = false;
            if (FormEditarUsuario == null)
            {
                FormEditarUsuario = new frmEditarUsuario(txtUsuario.Text, txtPrivilegio.Text);
                FormEditarUsuario.MdiParent = this;
                FormEditarUsuario.FormClosed += new FormClosedEventHandler(FormEditarUsuario_closed);
                FormEditarUsuario.Show();
            }                                  
        }        
        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            subMenuMantenimiento.Visible = false;
            if (FormCambiarPassword == null)
            {
                FormCambiarPassword = new frmCambiarPassword(txtUsuario.Text, txtPrivilegio.Text);
                FormCambiarPassword.MdiParent = this;
                FormCambiarPassword.FormClosed += new FormClosedEventHandler(FormCambiarPassword_closed);
                FormCambiarPassword.Show();
            }                       
        }
        
        //button inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (SubMenuInventario.Visible == true)
            {
                subMenuInsidencias.Visible = false;
                subMenuMantenimiento.Visible = false;
                SubMenuInventario.Visible = false;                                                
            }
            else
            {                
                subMenuInsidencias.Visible = false;
                subMenuMantenimiento.Visible = false;
                SubMenuInventario.Visible = true;                                             
            }
        }
        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            SubMenuInventario.Visible = false;
            if (FormAgregarInventario == null)
            {
                FormAgregarInventario = new frmAgregarInventario();
                FormAgregarInventario.MdiParent = this;
                FormAgregarInventario.FormClosed += new FormClosedEventHandler(FormAgregarInventario_closed);
                FormAgregarInventario.Show();
            }                                 
        }
        private void BtnConfigurarInventario_Click(object sender, EventArgs e)
        {
            SubMenuInventario.Visible = false;
            if (FormEditarInventario == null)
            {
                FormEditarInventario = new frmEditarInventario();
                FormEditarInventario.MdiParent = this;
                FormEditarInventario.FormClosed += new FormClosedEventHandler(FormEditarInventario_closed);
                FormEditarInventario.Show();
            }                     
        }
        private void BtnVerInventario_Click(object sender, EventArgs e)
        {
            SubMenuInventario.Visible = false;
            if (FormVerInventario == null)
            {
                FormVerInventario = new frmVerInventario();
                FormVerInventario.MdiParent = this;
                FormVerInventario.FormClosed += new FormClosedEventHandler(FormVerInventario_closed);
                FormVerInventario.Show();
            }                       
        }
        

        //button Reportes        

        //button log out
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA CERRAR SESION?", "CERRAR SESION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrivilegio_TextChanged(object sender, EventArgs e)
        {

        }

        //button exit
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA SALIR?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
             
    }
}
