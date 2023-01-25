using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC_CEA_SYSTEM.Model;
using TIC_CEA_SYSTEM.Controller;

namespace TIC_CEA_SYSTEM.View
{
    public partial class frmCambiarPassword : Form
    {
        cPersona ControllerPersona = new cPersona();
        mPersona ModelPersona = new mPersona();
        
        private void ClearAll()
        {
            cbUsuario.Items.Clear();
            txtNuevaContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
            cbUsuario.Items.Clear();
            txtNuevaContraseña.Focus();
        }
        public frmCambiarPassword(string Usuairo,string Privilegio)
        {
            InitializeComponent();
            txtSoporte.Visible = false;
            txtSoporte.Text = Usuairo;
            txtPrivilegio.Text = Privilegio;
            txtPrivilegio.Visible = false;
        }
        private void CallUser()
        {
            if (txtPrivilegio.Text == "ROOT")
            {
                ControllerPersona.SQL = "SELECT PersonUser FROM Person WHERE PersonUser = '" + txtSoporte.Text + "' OR PersonPrivilege='ENCARGADO/A' OR PersonPrivilege='SOPORTE' OR PersonPrivilege='ADMINISTRADOR/A' ORDER BY PersonUser asc";
            }
            else if (txtPrivilegio.Text == "ADMINISTRADOR/A")
            {
                ControllerPersona.SQL = "SELECT PersonUser FROM Person WHERE PersonUser = '" + txtSoporte.Text + "' OR (PersonPrivilege='ENCARGADO/A' OR PersonPrivilege='SOPORTE')";
            }
            else if (txtPrivilegio.Text == "ENCARGADO/A")
            {
                ControllerPersona.SQL = "SELECT PersonUser FROM Person WHERE PersonUser = '" + txtSoporte.Text + "' OR PersonPrivilege='SOPORTE'";
            }
            else if (txtPrivilegio.Text == "SOPORTE")
            {
                ControllerPersona.SQL = "SELECT PersonUser FROM Person WHERE PersonUser = '" + txtSoporte.Text + "' AND PersonPrivilege='SOPORTE'";
            }
            ControllerPersona.ComboBox = cbUsuario;            
            ModelPersona.ShowUsuario(ControllerPersona);
        }
        private void frmCambiarPassword_Load(object sender, EventArgs e)
        {
            CallUser();
        }

        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = cbUsuario.Text;
            string contraseña = txtNuevaContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;
            if (usuario != "")
            {
                
                    if (contraseña != "")
                    {
                        if (confirmarContraseña != "")
                        {
                            if (contraseña == confirmarContraseña)
                            {
                                ControllerPersona.SQL = "UPDATE Person SET PersonPassword = @Password WHERE PersonUser = @User";
                                ControllerPersona.password = contraseña;
                                ControllerPersona.usuario = usuario;
                                ControllerPersona.idPersona = 0;
                                ControllerPersona.Nombres = "";
                                ControllerPersona.apellidos = "";
                                ControllerPersona.cedula = "";
                                ControllerPersona.privilegio = "";
                                ControllerPersona.estado = false;
                                ControllerPersona.Lastlogin = "";

                                if (ModelPersona.UpdatePersona(ControllerPersona))
                                {
                                    MessageBox.Show("LA CONTRASEÑA FUE CAMBIADA", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ClearAll();
                                    CallUser();                                    
                                }
                                else
                                {
                                    MessageBox.Show("LA CONTRASEÑA NO PUDO SER CAMBIADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE CONFIRMAR LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE TENER INGRESAR LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                               
            }
            else
            {
                MessageBox.Show("PRIMERO DEBE SELECCIONAR UN USAUARIO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearAll();
            CallUser();            
        }
    }
}
