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
using TIC_CEA_SYSTEM.Model;
using TIC_CEA_SYSTEM.Controller;

namespace TIC_CEA_SYSTEM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwd, int wsg, int wparam, int Imparam);

        mLogin ModelLogin = new mLogin();        
        View.Main menu = new View.Main();
        cPersona ControllerPersona = new cPersona();
        mPersona ModelPersona = new mPersona();


        private void Enter()
        {
            txtPassword.UseSystemPasswordChar = true;
            if (txtUser.Text != "USUARIO")
            {
                if (txtPassword.Text != "PASSWORD")
                {

                    ControllerPersona.SQL = "SELECT idPerson,PersonName,PersonaLastname,PersonUser,PersonPassword,PersonPrivilege,PersonStatud FROM Person";
                    ControllerPersona.usuario = txtUser.Text;
                    ControllerPersona.password = txtPassword.Text;
                    cPersona Result = ModelLogin.Authentichate(ControllerPersona);
                    if (Result.usuario != "")
                    {
                        if (Result.password != null)
                        {
                            if (Result.estado)
                            {
                                ControllerPersona.SQL = "UPDATE Person SET PersonLastLogin = (SELECT SYSDATETIME()) WHERE idPerson = @idEmpleado";
                                ControllerPersona.idPersona = Result.idPersona;
                                ControllerPersona.Nombres = "";
                                ControllerPersona.apellidos = "";
                                ControllerPersona.cedula = "";
                                ControllerPersona.privilegio = "";
                                ControllerPersona.estado = false;
                                ControllerPersona.password = "";
                                ControllerPersona.usuario = "";
                                ModelPersona.UpdatePersona(ControllerPersona);
                                this.Hide();
                                View.Main MainMenu = new View.Main();
                                View.Bienvenida Welcom = new View.Bienvenida();

                                Welcom.lblName.Text = Result.Nombres;
                                Welcom.lblLastname.Text = Result.apellidos;

                                MainMenu.txtUsuario.Text = Result.usuario;
                                MainMenu.txtPrivilegio.Text = Result.privilegio;
                                MainMenu.txtNombre.Text = Result.Nombres;

                                Welcom.ShowDialog();
                                MainMenu.Show();
                                MainMenu.FormClosed += Logout;
                            }
                            else
                            {
                                MessageBox.Show("ESTE USUARIO ESTA DESACTIVADO, PARA MAS INFORMACION CONTACTE SU SUPERVISOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CONTRASEÑA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Focus();
                            txtPassword.Text = "";
                            txtPassword.ForeColor = Color.Black;
                            txtPassword.UseSystemPasswordChar = false;                                                       
                        }
                    }
                    else
                    {
                        MessageBox.Show("ESTE USUARIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "PASSWORD";
                        txtPassword.ForeColor = Color.Black;
                        txtPassword.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR DATOS EN EL CAMPO DE PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR DATOS EN EL CAMPO DE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Logout(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            this.Show();
            txtUser.Text = "USUARIO";
            txtPassword.Text = "PASSWORD";
            txtPassword.UseSystemPasswordChar = false;
            txtUser.Focus();
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Enter();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Enter();            
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
