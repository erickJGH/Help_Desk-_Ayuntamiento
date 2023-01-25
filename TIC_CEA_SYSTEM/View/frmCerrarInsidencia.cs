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
    public partial class frmCerrarInsidencia : Form
    {
        cInsidencia ControllerInsidencia = new cInsidencia();
        mInsidencia ModelInsidencia = new mInsidencia();
        
        public frmCerrarInsidencia(string Usuario,string Nombre)
        {
            InitializeComponent();
            txtSoluccionTicket.Enabled = false;
            txtNombre.Visible = false;
            txtNumeroTicket.Enabled = false;

            cbPiezas.Visible = false;
            cbSoporteColaborador.Visible = false;

            txtSoporte.Visible = false;
            txtSoporte.Text = Usuario;            
            txtNombre.Text = Nombre;

            rbNoColaborador.Checked = true;
            rbNoPieza.Checked = true;
        }

        private void Datos()
        {
            int ID = Convert.ToInt32(txtNumeroTicket.Text);
            ControllerInsidencia.idInsidecias = ID;
            ControllerInsidencia.Solucion = txtSoluccionTicket.Text;
            ControllerInsidencia.EstatudInsidencia = false;
            ControllerInsidencia.Departamento = "";
            ControllerInsidencia.UsuarioReportante = "";
            ControllerInsidencia.DetalleInsidencia = "";
            ControllerInsidencia.CategoriaInsidencia = "";
            ControllerInsidencia.EquipoComponente = "";
            ControllerInsidencia.TipoInsidencia = "";
            ControllerInsidencia.ExtensionDepartamento = "";
            ControllerInsidencia.NombreSoporte = "";
            
        }
        private void CleanAll()
        {            
            txtNumeroTicket.Text = "";
            txtSoluccionTicket.Text = "";    
                        
            rbSiPieza.Enabled = false;            
            rbSiColaborador.Enabled = false;
            txtSoluccionTicket.Enabled = false;

            cbPiezas.Items.Clear();
            cbSoporteColaborador.Items.Clear();
            cbPiezas.Visible = false;
            cbSoporteColaborador.Visible = false;

            btnCancelarSoluccion.Enabled = false;
            btnGuardarSoluccion.Enabled = false;

            btnGuardarSoluccion.BackColor = Color.DarkGray;
            btnCancelarSoluccion.BackColor = Color.DarkGray;
                        
            rbNoColaborador.Checked = true;
            rbNoPieza.Checked = true;
        }
        //public void Notification()
        //{
        //    Incidencia.Text = "Usted posee una nueva incidencia";
        //    Incidencia.BalloonTipTitle = "Notificacion";
        //    Incidencia.BalloonTipText = "Revise su perfil, ya que posee una nueva  incidencia";
        //    Incidencia.BalloonTipIcon = ToolTipIcon.Info;
        //    Incidencia.Visible = true;
        //    Incidencia.ShowBalloonTip(5000);
        //}
        private void frmCerrarInsidencia_Load(object sender, EventArgs e)
        {
            timer1.Start();            
            CleanAll();            
            ShowIncidencia();
            //Notification();
        }
        public void ShowIncidencia()
        {
            if (txtNombre.Text == "ROOT" || txtNombre.Text == "ADMINISTRADOR/A")
            {
                ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as USUARIO,Incidencia.Detalles as DETALLE,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD from Incidencia inner join Deparment on Incidencia.idDepartamento = Deparment.idDeparment inner join Person on Incidencia.Soporte = Person.PersonName WHERE Incidencia.Statud = 1 order by Incidencia.idIncidencia asc";
            }
            else if (txtNombre.Text == "SOPORTE")
            {
                ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as USUARIO,Incidencia.Detalles as DETALLE,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD from Incidencia inner join Deparment on Incidencia.idDepartamento = Deparment.idDeparment inner join Person on Incidencia.Soporte = Person.PersonName WHERE Person.PersonName = '" + txtSoporte.Text + "' AND Incidencia.Statud = 1 order by Incidencia.idIncidencia asc";
            }
            ControllerInsidencia.NombreTabla = dgvCerrarIncidencia;
            ModelInsidencia.ShowInsidencias(ControllerInsidencia);
        }
        
        private void dgvCerrarIncidencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtNumeroTicket.Text = "";
                txtSoluccionTicket.Text = "";                
                rbSiPieza.Enabled = true;
                rbSiColaborador.Enabled = true;
                cbPiezas.Items.Clear();
                cbSoporteColaborador.Items.Clear();

                

                txtSoluccionTicket.Enabled = true;
                btnCancelarSoluccion.Enabled = true;
                btnGuardarSoluccion.Enabled = true;

                btnGuardarSoluccion.BackColor = Color.White;
                btnCancelarSoluccion.BackColor = Color.White;
                cbPiezas.BackColor = Color.White;
                cbSoporteColaborador.BackColor = Color.White;

                DataGridViewRow dvgClose = dgvCerrarIncidencia.Rows[e.RowIndex];
                txtNumeroTicket.Text = dvgClose.Cells[0].Value.ToString();
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ShowIncidencia();
        }

        private void btnCancelarSoluccion_Click(object sender, EventArgs e)
        {                        
            CleanAll();
        }

        private void btnGuardarSoluccion_Click(object sender, EventArgs e)
        {
            if (txtSoluccionTicket.Text !="")
            {
                if (rbSiPieza.Checked && rbSiColaborador.Checked)
                {
                    if (cbPiezas.Text != "")
                    {
                        if (cbSoporteColaborador.Text != "")
                        {
                            ControllerInsidencia.SQL = "UPDATE Incidencia SET FechaCierre = (select CONVERT(date, GETUTCDATE())), HoraCierre = (SELECT CONVERT(char(8), getdate(), 108) as [hh:mm:ss]), Solucion = @Solucion,Statud = @Estatus,Pieza = @pieza,Colaborador = @Colaborador WHERE idIncidencia = @idIncidencia";
                            Datos();
                            ControllerInsidencia.Pieza = cbPiezas.Text;
                            ControllerInsidencia.PersonaColaboracion = cbSoporteColaborador.Text;
                            if (ModelInsidencia.UpdateIncidencia(ControllerInsidencia))
                            {                                
                                MessageBox.Show("ESTA INCIDENCIA FUE CERRADA CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                CleanAll();
                                ShowIncidencia();
                            }
                            else
                            {
                                MessageBox.Show("ERROR AL INTENTAR CERRAR ESTA INSIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE SELECCIONAR UN SOPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR UNA PIEZA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbSiPieza.Checked && rbSiColaborador.Checked == false)
                {
                    if (cbPiezas.Text != "")
                    {

                        ControllerInsidencia.SQL = "UPDATE Incidencia SET FechaCierre = (select CONVERT(date, GETUTCDATE())), HoraCierre = (SELECT CONVERT(char(8), getdate(), 108) as [hh:mm:ss]), Solucion = @Solucion,Statud = @Estatus,Pieza = @pieza WHERE idIncidencia = @idIncidencia";
                        Datos();
                        ControllerInsidencia.Pieza = cbPiezas.Text;
                        ControllerInsidencia.PersonaColaboracion = "";
                        if (ModelInsidencia.UpdateIncidencia(ControllerInsidencia))
                        {                            
                            MessageBox.Show("ESTA INCIDENCIA FUE CERRADA CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            CleanAll();
                            ShowIncidencia();
                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INTENTAR CERRAR ESTA INSIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR UNA PIEZA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbSiPieza.Checked == false && rbSiColaborador.Checked)
                {
                    if (cbSoporteColaborador.Text != "")
                    {
                        ControllerInsidencia.SQL = "UPDATE Incidencia SET FechaCierre = (select CONVERT(date, GETUTCDATE())), HoraCierre = (SELECT CONVERT(char(8), getdate(), 108) as [hh:mm:ss]), Solucion = @Solucion,Statud = @Estatus,Colaborador = @Colaborador WHERE idIncidencia = @idIncidencia";
                        Datos();
                        ControllerInsidencia.Pieza = "";
                        ControllerInsidencia.PersonaColaboracion = cbSoporteColaborador.Text;
                        if (ModelInsidencia.UpdateIncidencia(ControllerInsidencia))
                        {                            
                            MessageBox.Show("ESTA INCIDENCIA FUE CERRADA CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            CleanAll();
                            ShowIncidencia();
                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INTENTAR CERRAR ESTA INSIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR UN SOPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ControllerInsidencia.SQL = "UPDATE Incidencia SET FechaCierre = (select CONVERT(date, GETUTCDATE())), HoraCierre = (SELECT CONVERT(char(8), getdate(), 108) as [hh:mm:ss]), Solucion = @Solucion,Statud = @Estatus WHERE idIncidencia = @idIncidencia";
                    Datos();
                    ControllerInsidencia.Pieza = "";
                    ControllerInsidencia.PersonaColaboracion = "";
                    if (ModelInsidencia.UpdateIncidencia(ControllerInsidencia))
                    {                        
                        MessageBox.Show("ESTA INCIDENCIA FUE CERRADA CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CleanAll();
                        ShowIncidencia();
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL INTENTAR CERRAR ESTA INSIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR LA SOLUCCION DE LA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbConfirmacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSiPieza.Checked)
            {
                cbPiezas.Visible = true;
                cbPiezas.Items.Clear();
                ControllerInsidencia.SQL = "SELECT Pieza FROM Pieza  ORDER BY Pieza ASC";
                ControllerInsidencia.ComboBox = cbPiezas;
                ModelInsidencia.ShowCombobox(ControllerInsidencia);                
            }                        
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (txtNombre.Text == "ROOT" || txtNombre.Text == "ADMINISTRADOR/A")
                {
                    ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as USUARIO,Incidencia.Detalles as DETALLE,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD FROM Incidencia inner join Deparment on Incidencia.idDepartamento = Deparment.idDeparment inner join Person on Incidencia.Soporte = Person.PersonName AND Incidencia.Statud = 1 WHERE Deparment.DeparmentName LIKE'%" + textBox1.Text + "%'  ";
                }
                else
                {
                    ControllerInsidencia.SQL = "SELECT Incidencia.idIncidencia as TICKET,Deparment.DeparmentName as DEPARTAMENTO,Incidencia.ExtencionDepartamento as EXTENSION,Incidencia.PersonaReporte as USUARIO,Incidencia.Detalles as DETALLE,Incidencia.TipoIncidencia as TIPO,Person.PersonName as SOPORTE,Incidencia.Componente as COMPONENTE,Incidencia.FechaIncio as APERTURA,Incidencia.Statud AS ESTATUD FROM Incidencia inner join Deparment on Incidencia.idDepartamento = Deparment.idDeparment inner join Person on Incidencia.Soporte = Person.PersonName AND Incidencia.Statud = 1 WHERE Person.PersonName = '" + txtSoporte.Text + "' AND Deparment.DeparmentName LIKE'%" + textBox1.Text + "%'  ";                    
                }
                ControllerInsidencia.NombreTabla = dgvCerrarIncidencia;
                ModelInsidencia.ShowInsidencias(ControllerInsidencia);

            }
            else
            {
                ShowIncidencia();
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowIncidencia();
        }

        private void DgvCerrarIncidencia_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Notification();
        }

        private void RbNoPieza_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNoPieza.Checked)
            {
                cbPiezas.Visible = false;
            }
        }

        private void RbSiColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSiColaborador.Checked)
            {
                cbSoporteColaborador.Items.Clear();
                cbSoporteColaborador.Visible = true;
                ControllerInsidencia.SQL = "SELECT PersonName FROM Person where PersonPrivilege = 'SOPORTE'  ORDER BY PersonName  ASC";
                ControllerInsidencia.ComboBox = cbSoporteColaborador;
                ModelInsidencia.ShowCombobox(ControllerInsidencia);
            }
        }

        private void RbNoColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoColaborador.Checked)
            {
                cbSoporteColaborador.Visible = false;
            }
        }
    }
}
