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
    public partial class frmAgregarUsuario : Form
    {
        ValidarEntrada Validate = new ValidarEntrada();
        cPersona ControllerPersona = new cPersona();
        mPersona ModelPersona = new mPersona();

        public void ClearAll()
        {
           
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            cbPrivilegios.Items.Clear();

            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtCedula.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmarPassword.Enabled = false;
            cbPrivilegios.Enabled = false;

            btnGuardarUsuario.Enabled = false;
            btnCancelarUsuario.Enabled = false;

            btnGuardarUsuario.BackColor = Color.DarkGray;
            btnCancelarUsuario.BackColor = Color.DarkGray;

            btnNuevoUsuario.Enabled = true;
            btnNuevoUsuario.BackColor = Color.White;
        }
        public frmAgregarUsuario(string Privilegio)
        {
            InitializeComponent();
            txtPrivilegio.Visible = false;
            txtPrivilegio.Text = Privilegio;
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";

            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            cbPrivilegios.Items.Clear();

            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtCedula.Enabled = true;

            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmarPassword.Enabled = true;
            cbPrivilegios.Enabled = true;

            btnGuardarUsuario.Enabled = true;
            btnCancelarUsuario.Enabled = true;

            btnGuardarUsuario.BackColor = Color.White;
            btnCancelarUsuario.BackColor = Color.White;

            btnNuevoUsuario.Enabled = false;
            btnNuevoUsuario.BackColor = Color.DarkGray;
            if (txtPrivilegio.Text == "ROOT")
            {
                cbPrivilegios.Items.Add("ROOT");
                cbPrivilegios.Items.Add("ENCARGADO/A");
                cbPrivilegios.Items.Add("ADMINISTRADOR/A");
                cbPrivilegios.Items.Add("INCIDENCIAS");
                cbPrivilegios.Items.Add("INVENTARIO");
                cbPrivilegios.Items.Add("SOPORTE");

            }
            else if (txtPrivilegio.Text == "ADMINISTRADOR/A")
            {
                cbPrivilegios.Items.Add("ENCARGADO/A");
                cbPrivilegios.Items.Add("ADMINISTRADOR/A");
                cbPrivilegios.Items.Add("INCIDENCIAS");
                cbPrivilegios.Items.Add("INVENTARIO");
                cbPrivilegios.Items.Add("SOPORTE");
            }
            else if (txtPrivilegio.Text == "ENCARGADO/A")
            {
                cbPrivilegios.Items.Add("ENCARGADO/A");
                cbPrivilegios.Items.Add("INCIDENCIAS");
                cbPrivilegios.Items.Add("INVENTARIO");
                cbPrivilegios.Items.Add("SOPORTE");
            }             
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate.ValidarSoloNumero(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate.ValidarLetrar(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate.ValidarLetrar(e);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string ConfirPassword = txtConfirmarPassword.Text;
            string privilegio = cbPrivilegios.Text;

            if (nombre != "")
            {
                if (apellidos != "")
                {
                    if (cedula != "")
                    {
                        if (usuario != "")
                        {
                            if (password != "")
                            {
                                if (ConfirPassword != "")
                                {
                                    if (privilegio != "")
                                    {
                                        ControllerPersona.usuario = txtCedula.Text;
                                        ControllerPersona.SQL = "SELECT PersonCedula from Person";
                                        ControllerPersona.ComboBox = null;
                                        if (ModelPersona.ShowUsuario(ControllerPersona))
                                        {
                                            ControllerPersona.usuario = txtUsuario.Text;
                                            ControllerPersona.SQL = "SELECT PersonUser from Person";
                                            ControllerPersona.ComboBox = null;
                                            if (ModelPersona.ShowUsuario(ControllerPersona))
                                            {
                                                if (password == ConfirPassword)
                                                {
                                                    ControllerPersona.SQL = "INSERT INTO Person(PersonName, PersonaLastname, PersonCedula, PersonUser, PersonPassword, PersonPrivilege, PersonStatud, PersonCreatedDate, PersonLastLogin) VALUES (@Nombre,@apellido,@cedula,@usuario,@password,@privilegio,@Estado,(SELECT SYSDATETIME()),(SELECT SYSDATETIME()))";
                                                    ControllerPersona.Nombres = nombre.ToUpper();
                                                    ControllerPersona.apellidos = apellidos.ToUpper();
                                                    ControllerPersona.cedula = cedula;
                                                    ControllerPersona.usuario = usuario;
                                                    ControllerPersona.password = password;
                                                    ControllerPersona.privilegio = privilegio;
                                                    ControllerPersona.estado = true;
                                                    if (ModelPersona.InsertPersona(ControllerPersona))
                                                    {
                                                        MessageBox.Show("EL USUARIO FUE GUARDADO CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                        ClearAll();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("ERROR AL INTENTAR GUARDAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtConfirmarPassword.Text = "";
                                                    txtPassword.Text = "";
                                                    txtPassword.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("ESTE USUARIO YA EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtUsuario.Text = "";
                                                txtUsuario.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("ESTA CEDULA ESTA ASIGNADA A OTRA PERSONA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtCedula.Text = "";
                                            txtCedula.Focus();
                                        }                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("PRIMERO DEBE SELECCIONA EL PRIVILEGIO DEL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("PRIMERO DEBES CONFIRMAR LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("PRIMERO DEBES INGRESAR UNA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PRIMERO DEBES INGRESAR EL NOMBRE DE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("PRIMERO DEBES INGRESAR LA CEDULA DEL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("PRIMERO DEBES INGRESAR EL APELLIDO DEL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("PRIMERO DEBES INGRESAR EL NOMBRE DEL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}