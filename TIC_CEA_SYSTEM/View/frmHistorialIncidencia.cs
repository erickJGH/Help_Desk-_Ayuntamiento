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
    public partial class frmHistorialIncidencia : Form
    {
        mInsidencia ModelIncidencia = new mInsidencia();
        cInsidencia ControllerIncidencia = new cInsidencia();

        mPersona ModelPersona = new mPersona();
        cPersona ControllerPersona = new cPersona();

        public void ShowDepartamentos()
        {
            ControllerPersona.SQL = "SELECT DeparmentName FROM Deparment";
            ControllerPersona.ComboBox = cbDepartamento;
            ModelPersona.ShowUsuario(ControllerPersona);
        }
        public void Incidens(string SQL)
        {            
            ControllerIncidencia.SQL = SQL;
            ShowIncidencia();
        }        
        public void ShowSoporte()
        {
            ControllerPersona.SQL = "SELECT PersonName FROM Person WHERE PersonPrivilege = 'SOPORTE'";
            ControllerPersona.ComboBox = cbSoporte;
            ModelPersona.ShowUsuario(ControllerPersona);
        }
        public void ShowIncidencia()
        {            
            ControllerIncidencia.NombreTabla = dgvHistorialIncidencias;
            ModelIncidencia.ShowInsidencias(ControllerIncidencia);            
        }
        public void TipoBusqueda()
        {
            cbTipoBusqueda.SelectedItem = 0;
            cbTipoBusqueda.Items.Add("TODOS");            
            cbTipoBusqueda.Items.Add("ABIERTAS");
            cbTipoBusqueda.Items.Add("CERRADAS");
            cbTipoBusqueda.Items.Add("DEPARTAMENTO");
            cbTipoBusqueda.Items.Add("SOPORTE");
            cbTipoBusqueda.Items.Add("CANTIDAD");
        }
        public frmHistorialIncidencia(string Nombre,string privilegio)
        {
            InitializeComponent();
            lblDepartamento.Visible = false;
            lblSoporte.Visible = false;
            cbDepartamento.Visible = false;
            cbSoporte.Visible = false;
            rbAbiertas.Visible = false;
            rbCerradas.Visible = false;
            rbTodas.Visible = false;

            txtNombre.Visible = false;
            txtPrivilegio.Visible = false;

            txtNombre.Text = Nombre;
            txtPrivilegio.Text = privilegio;
        }

        private void CbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPrivilegio.Text == "SOPORTE")
            {
                rbAbiertas.Visible = true;
                rbCerradas.Visible = true;
                rbTodas.Visible = true;
                lblBuscarPor.Visible = false;
                cbTipoBusqueda.Visible = false;
                rbTodas.Checked = true;

            }
            else
            {
                if (cbTipoBusqueda.Text == "TODOS")
                {
                    lblDepartamento.Visible = false;
                    lblSoporte.Visible = false;
                    cbDepartamento.Visible = false;
                    cbSoporte.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;
                    ControllerIncidencia.SQL = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment ORDER BY Incidencia.idIncidencia DESC";
                    ShowIncidencia();
                }
                else if (cbTipoBusqueda.Text == "ABIERTAS")
                {
                    lblDepartamento.Visible = false;
                    lblSoporte.Visible = false;
                    cbDepartamento.Visible = false;
                    cbSoporte.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;
                    ControllerIncidencia.SQL = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Statud = '1' ORDER BY Incidencia.idIncidencia DESC";
                    ShowIncidencia();
                }
                else if (cbTipoBusqueda.Text == "CERRADAS")
                {
                    lblDepartamento.Visible = false;
                    lblSoporte.Visible = false;
                    cbDepartamento.Visible = false;
                    cbSoporte.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;
                    ControllerIncidencia.SQL = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Statud = '0' ORDER BY Incidencia.idIncidencia DESC";
                    ShowIncidencia();
                }
                else if (cbTipoBusqueda.Text == "DEPARTAMENTO")
                {
                    lblDepartamento.Visible = true;
                    cbDepartamento.Visible = true;
                    cbDepartamento.Items.Clear();
                    lblSoporte.Visible = false;
                    cbSoporte.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;
                    ShowDepartamentos();
                    dgvHistorialIncidencias.DataSource = null;
                }
                else if (cbTipoBusqueda.Text == "SOPORTE")
                {
                    lblSoporte.Visible = true;
                    cbSoporte.Visible = true;
                    cbSoporte.Items.Clear();
                    lblDepartamento.Visible = false;
                    cbDepartamento.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;
                    ShowSoporte();
                    dgvHistorialIncidencias.DataSource = null;
                }
                else if (cbTipoBusqueda.Text == "CANTIDAD")
                {
                    lblDepartamento.Visible = false;
                    lblSoporte.Visible = false;
                    cbDepartamento.Visible = false;
                    cbSoporte.Visible = false;
                    rbAbiertas.Visible = false;
                    rbCerradas.Visible = false;
                    rbTodas.Visible = false;                    
                    ControllerIncidencia.SQL = "SELECT Soporte,count(Soporte) AS CANTIDAD FROM  Incidencia group by Soporte having count(Soporte)>0 order by count(Soporte) DESC";
                    ShowIncidencia();
                }
            }
           
        }

        private void FrmHistorialIncidencia_Load(object sender, EventArgs e)
        {            
            TipoBusqueda();
            cbTipoBusqueda.SelectedIndex = 0;
        }

        private void CbSoporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" +cbSoporte.Text + "' ORDER BY Incidencia.idIncidencia DESC";
            Incidens(sql);
            rbAbiertas.Visible = true;
            rbCerradas.Visible = true;
            rbTodas.Visible = true;
            rbTodas.Checked = true;
        }

        private void RbAbiertas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbiertas.Checked)
            {
                if (cbSoporte.Visible == true && cbSoporte.Text != "")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + cbSoporte.Text + "' AND Statud= 1 ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }
                else if (txtPrivilegio.Text == "SOPORTE")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + txtNombre.Text + "' AND Statud=1 ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }               

            }


        }

        private void RbCerradas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCerradas.Checked)
            {
                if (cbSoporte.Visible == true && cbSoporte.Text != "")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + cbSoporte.Text + "' AND Statud=0 ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }
                else if (cbDepartamento.Visible == true && cbDepartamento.Text != "")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Deparment.DeparmentName = '" + cbDepartamento.Text + "' AND Statud=0 ORDER BY Incidencia.idIncidencia DESC ";
                    Incidens(sql);
                }
                else if (txtPrivilegio.Text =="SOPORTE")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + txtNombre.Text + "' AND Statud=0 ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }

            }
                
            
        }

        private void RbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                if (cbSoporte.Visible == true && cbSoporte.Text != "")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + cbSoporte.Text + "' ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }
                else if (cbDepartamento.Visible == true && cbDepartamento.Text != "")
                {
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Deparment.DeparmentName = '" + cbDepartamento.Text + "' ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }
                else if (txtPrivilegio.Text == "SOPORTE")
                {                    
                    string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Incidencia.Soporte = '" + txtNombre.Text + "'  ORDER BY Incidencia.idIncidencia DESC";
                    Incidens(sql);
                }
            }            
        }

        private void CbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Incidencia.idIncidencia AS TICKET,Deparment.DeparmentName AS DEPARTAMENTO,ExtencionDepartamento AS EXTENCION,PersonaReporte AS USUARIO, Detalles AS INCIDENCIA,Solucion AS SOLUCION,Categoria AS CATEGORIA,TipoIncidencia AS TIPO,Soporte AS SOPORTE,Componente AS COMPONENTE,FechaIncio AS FECHA_INCIO, Horainicio AS HORA_INCIO,FechaCierre AS FECHA_CIERRE,HoraCierre AS HORA_CIERRE,Statud AS ESTADO,Pieza AS PIEZA_CAMBIADA FROM Incidencia INNER JOIN Deparment ON Incidencia.idDepartamento = Deparment.idDeparment WHERE Deparment.DeparmentName = '" + cbDepartamento.Text + "' ORDER BY Incidencia.idIncidencia DESC";
            Incidens(sql);
            rbAbiertas.Visible = true;
            rbCerradas.Visible = true;
            rbTodas.Visible = true;
            rbTodas.Checked = true;
        }
    }
}
