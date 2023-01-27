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
using TIC_CEA_SYSTEM.View;

namespace TIC_CEA_SYSTEM.View
{
    public partial class frmEditarInsidencias : Form
    {
        cInsidencia ControllerInsidencia = new cInsidencia();
        mInsidencia ModelInsidencia = new mInsidencia();
        cPersona ControllerPersona = new cPersona();
        private void ClearAll()
        {
            txtNumeroTicketConfig.Text = "";
            cbDepartamentoConfig.Items.Clear();
            txtUsuarioReportanteCofig.Text = "";
            txtDetalleReporteConfig.Text = "";
            cbCategoriaConfig.Items.Clear();
            cbComponenteEquipoConfig.Items.Clear();
            cbTipoConfig.Items.Clear();
            txtExtensionTelefonoConfig.Text = "";
            cbSoporteConfig.Items.Clear();

            cbDepartamentoConfig.Enabled = false;
            txtUsuarioReportanteCofig.Enabled = false;
            txtDetalleReporteConfig.Enabled = false;
            cbCategoriaConfig.Enabled = false;
            cbComponenteEquipoConfig.Enabled = false;
            cbTipoConfig.Enabled = false;
            txtExtensionTelefonoConfig.Enabled = false;
            cbSoporteConfig.Enabled = false;            
       
            btnBorrarInsidencia.Enabled = false;
            btnCancelarInsidencia.Enabled = false;
            btnGuardarInsidencia.Enabled = false;

            btnBorrarInsidencia.BackColor = Color.DarkGray;
            btnCancelarInsidencia.BackColor = Color.DarkGray;
            btnGuardarInsidencia.BackColor = Color.DarkGray;
        }
        private void ShowIncidencias()
        {
            ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as USUARIO,Incidencia.Detalles as DETALLE,Incidencia.Categoria as CATEGORIA,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD, PersonaAsignacion AS ENCARGADO_ASIGNACION from Incidencia inner join Deparment on Deparment.idDeparment = Incidencia.idDepartamento inner join Person on Incidencia.Soporte = Person.PersonName WHERE Incidencia.Statud = 1";
            ControllerInsidencia.NombreTabla = dgvConfigurarIncidencia;
            ModelInsidencia.ShowInsidencias(ControllerInsidencia);
        }
        public frmEditarInsidencias(string usuario)
        {
            InitializeComponent();
            txtNumeroTicketConfig.Enabled = false;
            txtNombreEncargado.Visible = false;
            txtNombreEncargado.Text = usuario;
        }       
        private void frmConfigurarInsidencias_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ClearAll();
            ShowIncidencias();
        }
        private void dgvConfigurarIncidencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtNumeroTicketConfig.Text = "";
                cbDepartamentoConfig.Items.Clear();
                txtUsuarioReportanteCofig.Text = "";
                txtDetalleReporteConfig.Text = "";
                cbCategoriaConfig.Items.Clear();
                cbComponenteEquipoConfig.Items.Clear();
                cbTipoConfig.Items.Clear();
                txtExtensionTelefonoConfig.Text = "";
                cbSoporteConfig.Items.Clear();

                btnBorrarInsidencia.BackColor = Color.White;
                btnCancelarInsidencia.BackColor = Color.White;
                btnGuardarInsidencia.BackColor = Color.White;


                cbDepartamentoConfig.Enabled = true;
                txtUsuarioReportanteCofig.Enabled = true;
                txtDetalleReporteConfig.Enabled = true;
                cbCategoriaConfig.Enabled = true;
                cbComponenteEquipoConfig.Enabled = true;
                cbTipoConfig.Enabled = true;
                txtExtensionTelefonoConfig.Enabled = true;
                cbSoporteConfig.Enabled = true;                

                btnBorrarInsidencia.Enabled = true;
                btnCancelarInsidencia.Enabled = true;
                btnGuardarInsidencia.Enabled = true;

                DataGridViewRow dvgConfig = dgvConfigurarIncidencia.Rows[e.RowIndex];
                txtNumeroTicketConfig.Text = dvgConfig.Cells[0].Value.ToString();
                cbDepartamentoConfig.Items.Add(dvgConfig.Cells[1].Value.ToString());
                cbDepartamentoConfig.SelectedIndex = 0;

                txtExtensionTelefonoConfig.Text = dvgConfig.Cells[2].Value.ToString();
                txtUsuarioReportanteCofig.Text = dvgConfig.Cells[3].Value.ToString();
                txtDetalleReporteConfig.Text = dvgConfig.Cells[4].Value.ToString();

                cbCategoriaConfig.Items.Add(dvgConfig.Cells[5].Value.ToString());
                cbCategoriaConfig.SelectedIndex = 0;              

                if (dvgConfig.Cells[6].Value.ToString() == "INCIDENCIA")
                {
                    cbTipoConfig.Items.Add(dvgConfig.Cells[6].Value.ToString());
                    cbTipoConfig.Items.Add("ASIGNACION");
                    cbTipoConfig.SelectedIndex = 0;
                }
                else if (dvgConfig.Cells[6].Value.ToString() == "ASIGNACION")
                {
                    cbTipoConfig.Items.Add(dvgConfig.Cells[6].Value.ToString());
                    cbTipoConfig.Items.Add("INCIDENCIA");
                    cbTipoConfig.SelectedIndex = 0;
                }
                                

                cbSoporteConfig.Items.Add(dvgConfig.Cells[7].Value.ToString());
                cbSoporteConfig.Text = dvgConfig.Cells[7].Value.ToString();

                cbComponenteEquipoConfig.Items.Add(dvgConfig.Cells[8].Value.ToString());                
                cbComponenteEquipoConfig.Text = dvgConfig.Cells[8].Value.ToString();                

                if (dvgConfig.Cells[5].Value.ToString() == "SOFTWARE")
                {
                    cbCategoriaConfig.Items.Add("HARDWARE");
                    cbCategoriaConfig.Items.Add("REDES");
                }
                else if (dvgConfig.Cells[5].Value.ToString() == "HARDWARE")
                {
                    cbCategoriaConfig.Items.Add("SOFTWARE");
                    cbCategoriaConfig.Items.Add("REDES");
                }
                else if (dvgConfig.Cells[5].Value.ToString() == "REDES")
                {
                    cbCategoriaConfig.Items.Add("SOFTWARE");
                    cbCategoriaConfig.Items.Add("HARDWARE");
                }
                
                ControllerInsidencia.SQL = "SELECT PersonName from Person WHERE PersonPrivilege = 'SOPORTE'";
                ControllerInsidencia.ComboBox = cbSoporteConfig;
                ModelInsidencia.ShowCombobox(ControllerInsidencia);

                ControllerInsidencia.SQL = "SELECT DeparmentName from Deparment";
                ControllerInsidencia.ComboBox = cbDepartamentoConfig;
                ModelInsidencia.ShowCombobox(ControllerInsidencia);
            }            
        }
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            txtBuscarConfig.Text = "";
            ShowIncidencias();
        }
        private void cbCategoriaConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Count = cbCategoriaConfig.SelectedIndex;
            cbComponenteEquipoConfig.Items.Clear();
            if (cbCategoriaConfig.Text == "SOFTWARE")
            {
                ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'SOFTWARE'";
            }
            else if (cbCategoriaConfig.Text == "HARDWARE")
            {
                ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'HARDWARE'";
            }
            else if (cbCategoriaConfig.Text == "REDES")
            {
                ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'REDES'";
            }
            ControllerInsidencia.ComboBox = cbComponenteEquipoConfig;
            ModelInsidencia.ShowCombobox(ControllerInsidencia);
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscarConfig.Text != "")
            {
                
                ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as REPORTANTE,Incidencia.Detalles as DETALLE,Incidencia.Categoria as CATEGORIA,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD,PersonaAsignacion AS ENCARGADO_ASIGNACION from Incidencia inner join Deparment on Incidencia.idDepartamento = Deparment.idDeparment inner join Person on Incidencia.Soporte = Person.PersonName WHERE Person.PersonName LIKE '%" + txtBuscarConfig.Text + "%' AND Incidencia.Statud = 1";
                ControllerInsidencia.NombreTabla = dgvConfigurarIncidencia;                
                ModelInsidencia.ShowInsidencias(ControllerInsidencia);               
            }
            else
            {
                ShowIncidencias();
            }
        }
        private void btnCancelarInsidencia_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnBorrarInsidencia_Click(object sender, EventArgs e)
        {


            if (Login.PrivilegioL == "ADMINISTRADOR/A")
            {
                DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR ESTA INCIDENCIA?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Answer == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(txtNumeroTicketConfig.Text);
                    ControllerInsidencia.idInsidecias = ID;
                    if (ModelInsidencia.DeleteIncidencia(ControllerInsidencia))
                    {
                        MessageBox.Show("LA INCIDENCIA FUE ELIMINADA CORRECTAMENTE!", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearAll();
                        ShowIncidencias();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL INTENTAR ELIMINAR ESTA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("USTED NO CUENTA CON LOS PRIVILEGIOS PARA BORRAR UNA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }
        private void btnGuardarInsidencia_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA GUARDAR ESTOS NUEVOS CAMBIOS?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                if (cbDepartamentoConfig.Text != "")
                {
                    if (txtUsuarioReportanteCofig.Text != "")
                    {
                        if (txtDetalleReporteConfig.Text != "")
                        {
                            if (cbCategoriaConfig.Text != "")
                            {
                                if (cbComponenteEquipoConfig.Text != "")
                                {
                                    if (cbTipoConfig.Text != "")
                                    {
                                        if (txtExtensionTelefonoConfig.Text != "")
                                        {
                                            if (cbSoporteConfig.Text != "")
                                            {
                                                
                                                    int ID = Convert.ToInt32(txtNumeroTicketConfig.Text);                                                   
                                                    
                                                    ControllerInsidencia.SQL = "UPDATE Incidencia set idDepartamento = (SELECT idDeparment FROM Deparment where DeparmentName = @nombreDepartamento),ExtencionDepartamento = @Extencion,PersonaReporte = @Reportante,Detalles = @Detalle,Categoria = @Categorie,TipoIncidencia = @tipo,Soporte = @Soporte,Componente = @equipo where idIncidencia = @idIncidencia";
                                                    ControllerInsidencia.idInsidecias = ID;
                                                    ControllerInsidencia.Departamento = cbDepartamentoConfig.Text;
                                                    ControllerInsidencia.UsuarioReportante = txtUsuarioReportanteCofig.Text.ToUpper();
                                                    ControllerInsidencia.DetalleInsidencia = txtDetalleReporteConfig.Text.ToUpper();
                                                    ControllerInsidencia.CategoriaInsidencia = cbCategoriaConfig.Text;
                                                    ControllerInsidencia.EquipoComponente = cbComponenteEquipoConfig.Text;
                                                    ControllerInsidencia.TipoInsidencia = cbTipoConfig.Text;
                                                    ControllerInsidencia.ExtensionDepartamento = txtExtensionTelefonoConfig.Text.ToUpper();
                                                    ControllerInsidencia.NombreSoporte = cbSoporteConfig.Text;
                                                    ControllerInsidencia.EstatudInsidencia = false;
                                                    

                                                    ControllerInsidencia.Solucion = "";
                                                    ControllerInsidencia.FechaFinal = "";
                                                    ControllerInsidencia.Pieza = "";
                                                    ControllerInsidencia.PersonaColaboracion = "";

                                                    if (ModelInsidencia.UpdateIncidencia(ControllerInsidencia))
                                                    {
                                                        MessageBox.Show("LA INCIDENCIA FUE ATUALIZADA CORRECTAMENTE!", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                        ClearAll();
                                                        ShowIncidencias();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("HA OCURRIDO UN ERROR EN LA ATUALIZACION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("DEBE SELECCIONAR EL SOPORTE A CARGO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("DEBE INGRESAR LA EXTENSION DEL DEPARTAMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("DEBE SELECCIONAR EL TIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("DEBE SELECCIONAR UN EQUIPO O COMPONENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("DEBE SELECCIONAR UNA CATEGORIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE INGRESAR EL DETALLE DE LA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE INGRESAR EL NOMBRE DE LA PERSONA QUE REALIZO LA LAMADA PARA LA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE TENER UN DEPARTAMENTO SELECCIONADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowIncidencias();
        }
    }
}
