using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC_CEA_SYSTEM.Controller;
using TIC_CEA_SYSTEM.Model;

namespace TIC_CEA_SYSTEM.View
{
    public partial class frmEditarUsuario : Form
    {
        cPersona ControllerPersona = new cPersona();
        mPersona ModelPersona = new mPersona();
        public frmEditarUsuario(string Usuario,string Privilegio)
        {
            InitializeComponent();
            txtIdEmpleado.Visible = false;
            txtPrivilegio.Visible = false;
            txtNombreUsuario.Visible = false;
            txtPrivilegio.Text = Privilegio;
            txtNombreUsuario.Text = Usuario;

        }
        private void ClearAll()
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtCedula.Enabled = false;
            cbPrivilegio.Enabled = false;
            rbActive.Enabled = false;
            rbDisabled.Enabled = false;

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            cbPrivilegio.Items.Clear();
            rbActive.Checked = false;
            rbDisabled.Checked = false;

            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnDelete.BackColor = Color.DarkGray;
            btnSave.BackColor = Color.DarkGray;
            btnCancel.BackColor = Color.DarkGray;
        }
        private void ShowUser()
        {
            ControllerPersona.Tabla = dgvUsuarios;
            if (txtPrivilegio.Text == "ROOT")
            {                
                ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonUser != '" + txtNombreUsuario.Text+ "' ";                
            }
            else if(txtPrivilegio.Text == "ENCARGADO/A")
            {                
                ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonPrivilege='SOPORTE' ";   
            }
            else if (txtPrivilegio.Text == "ADMINISTRADOR/A")
            {                
                ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonPrivilege='SOPORTE' OR PersonPrivilege='ENCARGADO/A'";                              
            }
            ModelPersona.ShowPersona(ControllerPersona);
            dgvUsuarios.Columns[7].Visible = false;
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ShowUser();
            ClearAll();
        }
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            txtBuscarConfig.Text = "";
            ShowUser();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtIdEmpleado.Text = "";
                txtNombre.Enabled = true;
                txtApellidos.Enabled = true;
                txtCedula.Enabled = true;
                cbPrivilegio.Enabled = true;
                rbDisabled.Enabled = true;
                cbPrivilegio.Visible = true;
                rbActive.Enabled = true;
                cbPrivilegio.Items.Clear();

                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Visible = true;

                btnCancel.BackColor = Color.White;
                btnSave.BackColor = Color.White;
                btnDelete.BackColor = Color.White;

                DataGridViewRow dvgConfig = dgvUsuarios.Rows[e.RowIndex];
                txtNombre.Text = dvgConfig.Cells[0].Value.ToString();
                txtApellidos.Text = dvgConfig.Cells[1].Value.ToString();
                txtCedula.Text = dvgConfig.Cells[2].Value.ToString();
                cbPrivilegio.Items.Add(dvgConfig.Cells[4].Value.ToString());
                cbPrivilegio.SelectedIndex = 0;                
                if (txtPrivilegio.Text == "ROOT")
                {
                    if (dvgConfig.Cells[4].Value.ToString() == "SOPORTE")
                    {
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                        cbPrivilegio.Items.Add("ROOT");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "ADMINISTRADOR/A")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                        cbPrivilegio.Items.Add("ROOT");
                        cbPrivilegio.Items.Add("INCIDENCIA");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "ENCARGADO/A")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("ROOT");
                        cbPrivilegio.Items.Add("INCIDENCIA");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INCIDENCIAS")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("ROOT");                        
                        cbPrivilegio.Items.Add("INVENTARIO");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INVENTARIO")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("ROOT");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                }
                else if (txtPrivilegio.Text == "ADMINISTRADOR/A")
                {
                    if (dvgConfig.Cells[4].Value.ToString() == "SOPORTE")
                    {
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "ADMINISTRADOR/A")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "ENCARGADO/A")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INCIDENCIAS")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");                        
                        cbPrivilegio.Items.Add("INVENTARIO");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INVENTARIO")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("ADMINISTRADOR/A");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                }
                else if (txtPrivilegio.Text == "ENCARGADO/A")
                {
                    if (dvgConfig.Cells[4].Value.ToString() == "SOPORTE")
                    {                        
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }                    
                    else if (dvgConfig.Cells[4].Value.ToString() == "ENCARGADO/A")
                    {                        
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("INVENTARIO");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INCIDENCIAS")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");                        
                        cbPrivilegio.Items.Add("INVENTARIO");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                    else if (dvgConfig.Cells[4].Value.ToString() == "INVENTARIO")
                    {
                        cbPrivilegio.Items.Add("SOPORTE");
                        cbPrivilegio.Items.Add("INCIDENCIAS");
                        cbPrivilegio.Items.Add("ENCARGADO/A");
                    }
                }

                bool Result = Convert.ToBoolean(dvgConfig.Cells[5].Value.ToString());

                if (Result)
                {
                    rbActive.Checked = true;
                    rbDisabled.Checked = false;
                }
                else
                {
                    rbDisabled.Checked = true;
                    rbActive.Checked = false;
                }
                txtIdEmpleado.Text = dvgConfig.Cells[7].Value.ToString();                               
            }
            else
            {
                MessageBox.Show("ESTE ES LA CABECERA DE LA COLUMNA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR ESTE USUARIO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                ControllerPersona.idPersona = Convert.ToInt32(txtIdEmpleado.Text);
                if (ModelPersona.DeletePersona(ControllerPersona))
                {
                    MessageBox.Show("ESTE USUARIO FUE ELIMINADO CON EXITO", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearAll();
                    ShowUser();
                }
                else
                {
                    MessageBox.Show("ERROR AL INTENTAR ELIMINAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (txtApellidos.Text != "")
                {
                    if (txtCedula.Text != "")
                    {
                        if (cbPrivilegio.Text != "")
                        {
                            if (rbActive.Text != "" || rbDisabled.Text !="")
                            {
                                int ID = Convert.ToInt32(txtIdEmpleado.Text);
                                string nombre = txtNombre.Text;
                                string apellido = txtApellidos.Text;
                                string cedula = txtCedula.Text;
                                string privilegios = cbPrivilegio.Text;
                                bool Statud;                                
                                if (rbActive.Text == "ACTIVADO")
                                {
                                    Statud = true;                                    
                                }
                                else
                                {
                                    Statud = false;
                                }                                

                                ControllerPersona.SQL = "UPDATE Person SET PersonName = @nombre,PersonaLastname = @apellido,PersonCedula = @cedula,PersonPrivilege = @privilegio,PersonStatud = @estado WHERE idPerson = @idEmpleado";
                                ControllerPersona.idPersona = ID;
                                ControllerPersona.Nombres = nombre;
                                ControllerPersona.apellidos = apellido;
                                ControllerPersona.cedula = cedula;
                                ControllerPersona.privilegio = privilegios;
                                ControllerPersona.estado = Statud;
                                ControllerPersona.password = "";
                                ControllerPersona.usuario = "";                                
                                if (ModelPersona.UpdatePersona(ControllerPersona))
                                {
                                    MessageBox.Show("USUARIO MODIFICADO CON EXITO", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ClearAll();
                                    ShowUser();
                                }
                                else
                                {
                                    MessageBox.Show("ERROR AL INTENTAR MODIFICAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("DEBE MARCAR EL ESTADO DEL USUARIO MODIFICAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE SELECCIONA EL PRIVILEGIO PARA PODER MODIFICAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE LA CEDULA PARA PODER MODIFICAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN APELLIDO PARA PODER MODIFICAR ESTE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA PODER MODIFICAR ESTE USUARIO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void txtBuscarConfig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarConfig.Text != "")
            {
                ControllerPersona.Tabla = dgvUsuarios;
                if (txtPrivilegio.Text == "ROOT")
                {
                    ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonUser != '" + txtNombreUsuario.Text + "' AND PersonName LIKE '%" + txtBuscarConfig.Text + "%' ";
                }
                else if (txtPrivilegio.Text == "ENCARGADO/A")
                {
                    ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonPrivilege='SOPORTE' AND PersonName LIKE '%" + txtBuscarConfig.Text + "%' ";
                }
                else if (txtPrivilegio.Text == "ADMINISTRADOR/A")
                {
                    ControllerPersona.SQL = "select PersonName as NOMBRES ,PersonaLastname as APELLIDOS,PersonCedula AS CEDULA,PersonUser AS USUARIO,PersonPrivilege AS PRIVILEGIO,PersonStatud AS ESTADO,PersonLastLogin AS CONEXION,idPerson FROM Person WHERE PersonPrivilege='SOPORTE' OR PersonPrivilege='ENCARGADO/A' AND PersonName LIKE '%" + txtBuscarConfig.Text + "%'";
                }                
                ModelPersona.ShowPersona(ControllerPersona);
                dgvUsuarios.Columns[7].Visible = false;
            }
            else
            {
                ShowUser();
            }            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowUser();
        }
    }
}
