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
    public partial class frmVerInventario : Form
    {
        mInventario ModelInentario = new mInventario();
        cInventario ControllerInventario = new cInventario();

        mInsidencia ModelInsidencias = new mInsidencia();
        cInsidencia ControllerInsidencia = new cInsidencia();
        public void ShowPC()
        {            
            ControllerInventario.Tabla = dgvRemoto;
            ModelInentario.ShowInventario(ControllerInventario);                    
        }
        public void ComboBox()
        {
            ControllerInsidencia.SQL = "SELECT DeparmentName FROM Deparment ";
            ControllerInsidencia.ComboBox = cbDeparamento;
            ModelInsidencias.ShowCombobox(ControllerInsidencia);
        }
        


        public frmVerInventario()
        {
            InitializeComponent();
        }
        private void frmVerRemoto_Load(object sender, EventArgs e)
        {            
            ComboBox();
            rbTodas.Enabled = false;            
            rbCantidad.Enabled = false;            
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (rbTodas.Checked)
            {
                ControllerInventario.SQL = "SELECT NumeroInventariado as NUMERO_INVENTARIADO,(SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario where (SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) = '" + cbDeparamento.Text + "'";
                ShowPC();
            }
            else if(rbCantidad.Checked)
            {
                ControllerInventario.SQL = "SELECT (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) AS DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) = '" + cbDeparamento.Text + "' ";
                ShowPC();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (rbTodas.Checked)
                {
                    ControllerInventario.SQL = "SELECT NumeroInventariado as NUMERO_INVENTARIADO,(SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario where (SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) = '" + cbDeparamento.Text + "' and TipoEquipo LIKE '%" + textBox1.Text + "%'";
                    ShowPC();
                }
                else if (rbCantidad.Checked)
                {

                    ControllerInventario.SQL = "SELECT (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) AS DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) = '" + cbDeparamento.Text + "'  and TipoEquipo LIKE '%" + textBox1.Text + "%' ";
                    ShowPC();
                }
            }
            else
            {
                if (rbTodas.Checked)
                {
                    ControllerInventario.SQL = "SELECT NumeroInventariado as NUMERO_INVENTARIADO,(SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario where (SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) = '" + cbDeparamento.Text + "'";
                    ShowPC();
                }
                else if (rbCantidad.Checked)
                {

                    ControllerInventario.SQL = "SELECT (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) AS DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) = '" + cbDeparamento.Text + "'";
                    ShowPC();
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //if (rbTodas.Checked)
            //{
            //    ControllerInventario.SQL = "SELECT NumeroInventariado as INVENTARIADO,Departamento as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario";
            //    ShowPC();
            //}
            //else if (rbCantidad.Checked)
            //{
            //    ControllerInventario.SQL = "SELECT Departamento,TipoEquipo,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and Departamento = '" + cbDeparamento.Text + "' ";
            //    ShowPC();
            //}

        }

        private void CbEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (cbDeparamento.Text != "")
            {
                rbTodas.Enabled = true;               
                rbCantidad.Enabled = true;

                rbTodas.Checked = true;
                if (rbTodas.Checked)
                {
                    ControllerInventario.SQL = "SELECT NumeroInventariado as NUMERO_INVENTARIADO,(SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario where (SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) = '" + cbDeparamento.Text + "'";
                    ShowPC();
                }                
                else if (rbCantidad.Checked)
                {
                    ControllerInventario.SQL = "SELECT (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) AS DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) = '" + cbDeparamento.Text + "' ";
                    ShowPC();
                }
            }
            else
            {
                rbTodas.Enabled = false;                
                rbCantidad.Enabled = false;

                rbTodas.Checked = false;                
                rbCantidad.Checked = false;
            }                        
        }

        private void RbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked)
            {
                ControllerInventario.SQL = "SELECT NumeroInventariado as NUMERO_INVENTARIADO,(SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) as DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTATUS_EQUIPO,DescripcionEquipo AS DESCRIPCION FROM Inventario where (SELECT DeparmentName FROM  Deparment where idDeparment = Departamento) = '" + cbDeparamento.Text + "'";
                ShowPC();
            }
            
        }

        private void RbCantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantidad.Checked)
            {
                ControllerInventario.SQL = "SELECT (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) AS DEPARTAMENTO,TipoEquipo AS TIPO_EQUIPO,COUNT(*) AS CANTIDAD from Inventario GROUP BY Departamento,TipoEquipo HAVING COUNT(*)>0 and (SELECT DeparmentName FROM Deparment WHERE idDeparment = Departamento ) = '" + cbDeparamento.Text + "' ";
                ShowPC();
            }
            
        }      
        
    }
}
