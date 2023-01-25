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
using TIC_CEA_SYSTEM.View;
using System.Collections;

namespace TIC_CEA_SYSTEM.View
{
    public partial class frmAgregarInsidencia : Form
    {        
        mInsidencia ModelInsidencias = new mInsidencia();
        cInsidencia ControllerInsidencia = new cInsidencia();
        ValidarEntrada Validate = new ValidarEntrada();
        Main ID = new Main();

        public frmAgregarInsidencia(string User,string nombre)
        {
            InitializeComponent();
            txtNumeroTicket.Enabled = false;
            txtUsuarioRegistro.Text = User;
            txtUsuarioRegistro.Visible = false;
        }        
        public void CleanAll()
        {
            txtNumeroTicket.Text = "";
            cbDepartamento.Items.Clear();
            txtUsuarioReportante.Text = "";
            txtDetalleReporte.Text = "";
            cbCategoria.Items.Clear();
            cbComponenteEquipo.Items.Clear();
            cbTipo.Items.Clear();            
            txtExtensionTelefono.Text = "";
            cbSoporte.Items.Clear();

            cbDepartamento.Enabled = false;
            txtUsuarioReportante.Enabled = false;
            txtDetalleReporte.Enabled = false;            
            txtExtensionTelefono.Enabled = false;
            cbSoporte.Enabled = false;
            cbCategoria.Enabled = false;
            cbTipo.Enabled = false;
            cbComponenteEquipo.Enabled = false;
            btnCancelarInsidencia.Enabled = false;
            btnGuardarInsidencia.Enabled = false;

            cbDepartamento.BackColor = Color.DarkGray;
            txtUsuarioReportante.BackColor = Color.DarkGray;
            txtDetalleReporte.BackColor = Color.DarkGray;            
            txtExtensionTelefono.BackColor = Color.DarkGray;
            cbSoporte.BackColor = Color.DarkGray;
            cbCategoria.BackColor = Color.DarkGray;
            cbTipo.BackColor = Color.DarkGray;
            cbComponenteEquipo.BackColor = Color.DarkGray;
            btnCancelarInsidencia.BackColor = Color.DarkGray;
            btnGuardarInsidencia.BackColor = Color.DarkGray;

            btnNuevo.Enabled = true;
            btnNuevo.BackColor = Color.White;
        }
        private void frmAbriInsidencia_Load(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //this is the part for te complete the insidences
            txtNumeroTicket.Text = "";
            cbDepartamento.Items.Clear();
            txtUsuarioReportante.Text = "";
            txtDetalleReporte.Text = "";
            cbCategoria.Items.Clear();
            cbComponenteEquipo.Items.Clear();
            cbTipo.Items.Clear();            
            txtExtensionTelefono.Text = "";
            cbSoporte.Items.Clear();
            
            cbDepartamento.Enabled = true;
            txtUsuarioReportante.Enabled = true;
            txtDetalleReporte.Enabled = true;
            cbCategoria.Enabled = true;            
            cbTipo.Enabled = true;            
            txtExtensionTelefono.Enabled = true;
            cbSoporte.Enabled = true;

            //this is for the color
            cbDepartamento.BackColor = Color.White;
            txtUsuarioReportante.BackColor = Color.White;
            txtDetalleReporte.BackColor = Color.White;
            cbCategoria.BackColor = Color.White;
            cbTipo.BackColor = Color.White;
            
            txtExtensionTelefono.BackColor = Color.White;
            cbSoporte.BackColor = Color.White;

            //this part is for button                                                        
            btnCancelarInsidencia.Enabled = true;
            btnGuardarInsidencia.Enabled = true;

            btnCancelarInsidencia.BackColor = Color.White;
            btnGuardarInsidencia.BackColor = Color.White;

            btnNuevo.Enabled = false;
            btnNuevo.BackColor = Color.DarkGray;            

            txtNumeroTicket.Text = ModelInsidencias.ShowNumberTicket().ToString();

            cbCategoria.Items.Add("SOFTWARE");
            cbCategoria.Items.Add("HARDWARE");
            cbCategoria.Items.Add("REDES");

            cbTipo.Items.Add("INCIDENCIA");
            cbTipo.Items.Add("ASIGNACION");
            
            ControllerInsidencia.SQL = "SELECT PersonName FROM Person where PersonPrivilege = 'SOPORTE'";
            ControllerInsidencia.ComboBox = cbSoporte;
            ModelInsidencias.ShowCombobox(ControllerInsidencia);
            
            ControllerInsidencia.SQL = "SELECT DeparmentName FROM Deparment ";
            ControllerInsidencia.ComboBox = cbDepartamento;
            ModelInsidencias.ShowCombobox(ControllerInsidencia);
        }

        private void btnCancelarInsidencia_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void btnGuardarInsidencia_Click(object sender, EventArgs e)
        {            
            string Departamento = cbDepartamento.Text;
            string UsuarioReportante = txtUsuarioReportante.Text.ToUpper();
            string DetalleInsidencia = txtDetalleReporte.Text.ToUpper();
            string CategoriaInsidencia = cbCategoria.Text;
            string TipoInsidencia = cbTipo.Text;            
            string ExtensionDepartamento = txtExtensionTelefono.Text;
            string NombreSoporte = cbSoporte.Text;
            string EquipoComponente = cbComponenteEquipo.Text;

            if (Departamento != "")
            {
                if (UsuarioReportante != "")
                {
                    if (DetalleInsidencia != "")
                    {
                        if (CategoriaInsidencia != "")
                        {
                            if (EquipoComponente != "")
                            {
                                if (TipoInsidencia != "")
                                {
                                    if (ExtensionDepartamento != "")
                                    {
                                        if (NombreSoporte != "")
                                        {

                                            ControllerInsidencia.SQL = "INSERT INTO Incidencia(idDepartamento,ExtencionDepartamento,PersonaReporte,Detalles,Categoria,TipoIncidencia,Soporte,Componente,FechaIncio,Horainicio,Statud,PersonaAsignacion) VALUES ((select idDeparment from Deparment where DeparmentName = @Departamento),@Extencion,@Reportante,@Detalle,@Categoria,@Tipo,@IdSoporte,@Componente, (select CONVERT(date, GETUTCDATE())),(SELECT CONVERT(char(8), getdate(), 108) as [hh:mm:ss]),1,@PersonaAsignacion)";
                                            ControllerInsidencia.Departamento = Departamento;
                                            ControllerInsidencia.UsuarioReportante = UsuarioReportante;
                                            ControllerInsidencia.DetalleInsidencia = DetalleInsidencia;
                                            ControllerInsidencia.CategoriaInsidencia = CategoriaInsidencia;
                                            ControllerInsidencia.TipoInsidencia = TipoInsidencia;                                            
                                            ControllerInsidencia.ExtensionDepartamento = ExtensionDepartamento;
                                            ControllerInsidencia.NombreSoporte = NombreSoporte;
                                            ControllerInsidencia.EquipoComponente = EquipoComponente;
                                            ControllerInsidencia.PersonaAsignante = txtUsuarioRegistro.Text;
                                            if (ModelInsidencias.insertInsidencia(ControllerInsidencia))
                                            {
                                                MessageBox.Show("INCIDENCIA ASIGNADA CORRECTAMENTE","CORRECTO",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                                CleanAll();                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("ERROR EN ASIGNACION DE INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("DEBE SELECCIONA EL NOMBRE DEL SOPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("DEBE INGRESAR LA EXTENSION DEL DEPARTAMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("DEBE SELECCIONA EL TIPO DE INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("DEBE SELECCIONA UN EQUIPO O COMPONENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE SELECCIONA UNA CATEGORIA DE INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE INGRESAR EL DETALLE DE LA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR EL NOMBRE DEL USUARIO QUE REPORTO LA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR EL DEPARTAMENTO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                                               
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int Count = cbCategoria.SelectedIndex;
            if (Count > -1)
            {                
                cbComponenteEquipo.Enabled = true;
                cbComponenteEquipo.Items.Clear();
                cbComponenteEquipo.BackColor = Color.White;
                if (Count == 0)
                {                    
                    ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'SOFTWARE'";                    
                }
                else if (Count == 1)
                {
                    ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'HARDWARE'";
                }
                else if (Count == 2)
                {
                    ControllerInsidencia.SQL = "SELECT ComponentName FROM Component where ComponentCategorie = 'REDES'";
                }
                ControllerInsidencia.ComboBox = cbComponenteEquipo;
                ModelInsidencias.ShowCombobox(ControllerInsidencia);

            }
        }

        private void txtUsuarioReportante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate.ValidarLetrar(e);
        }

        private void txtExtensionTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate.ValidarSoloNumero(e);
        }
    }
}
