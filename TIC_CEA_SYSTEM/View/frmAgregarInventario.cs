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
    public partial class frmAgregarInventario : Form
    {
        mInventario ModelInventario = new mInventario();
        cInventario ControllerInventario = new cInventario();

        mInsidencia ModelInsidencias = new mInsidencia();
        cInsidencia ControllerInsidencia = new cInsidencia();
        public frmAgregarInventario()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txtNumeroInventarido.Enabled = false;
            cbEquipo.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            cbEstado.Enabled = false;
            txtDetalleEquipo.Enabled = false;
            cbDepartamento.Enabled = false;


            txtNumeroInventarido.Text = "";
            cbEquipo.Items.Clear();
            txtMarca.Text = "";
            txtModelo.Text = "";
            cbEstado.Items.Clear();
            txtDetalleEquipo.Text = "";
            cbDepartamento.Items.Clear();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            btnSave.BackColor = Color.DarkGray;
            btnCancel.BackColor = Color.DarkGray;

            btnNew.Enabled = true;
            btnNew.BackColor = Color.White;
        }
        
        private void frmAgregarRemoto_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNumeroInventarido.Enabled = true;
            cbEquipo.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            cbEstado.Enabled = true;
            txtDetalleEquipo.Enabled = true;
            cbDepartamento.Enabled = true;

            txtNumeroInventarido.Text = "";
            cbEquipo.Items.Clear();
            txtMarca.Text = "";
            txtModelo.Text = "";
            cbEstado.Items.Clear();
            txtDetalleEquipo.Text = "";            

            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            btnSave.BackColor = Color.White;
            btnCancel.BackColor = Color.White;

            btnNew.Enabled = false;
            btnNew.BackColor = Color.DarkGray;

            cbEquipo.Items.Add("COMPUTADORA");
            cbEquipo.Items.Add("IMPRESORA");
            cbEquipo.Items.Add("SCANER");
            cbEquipo.Items.Add("PROYECTOR");
            cbEquipo.Items.Add("UPS");
            cbEquipo.Items.Add("MONITOR");
            cbEquipo.Items.Add("ESCRITORIO");

            cbEstado.Items.Add("NUEVO");
            cbEstado.Items.Add("BUEN ESTADO");
            cbEstado.Items.Add("MEDIO USO");
            cbEstado.Items.Add("MAL ESTADO");

            ControllerInsidencia.SQL = "SELECT DeparmentName FROM Deparment";
            ControllerInsidencia.ComboBox = cbDepartamento;
            ModelInsidencias.ShowCombobox(ControllerInsidencia);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumeroInventarido.Text != "")
            {
                ControllerInventario.NumeroInventario = txtNumeroInventarido.Text;
                if (ModelInventario.ValidateInventarioNumber(ControllerInventario) != false)
                {                    
                    if (cbEquipo.Text != "")
                    {
                        if (txtMarca.Text != "")
                        {
                            if (txtModelo.Text != "")
                            {
                                if (cbEstado.Text != "")
                                {
                                    if (txtDetalleEquipo.Text != "")
                                    {
                                        if (cbDepartamento.Text != "")
                                        {

                                            ControllerInventario.SQL = "INSERT INTO Inventario (NumeroInventariado,TipoEquipo,Marca,Modelo,Estado,DescripcionEquipo,Disponibilidad,Departamento) VALUES (@NumeroInventarido,@TipoEquipo,@Marca,@Modelo,@Estado,@Detalles,@Disponibilidad,(SELECT idDeparment from Deparment where DeparmentName = @departamento))";
                                            ControllerInventario.NumeroInventario = txtNumeroInventarido.Text.ToUpper();
                                            ControllerInventario.Equipo = cbEquipo.Text;
                                            ControllerInventario.Marca = txtMarca.Text.ToUpper();
                                            ControllerInventario.Modelo = txtModelo.Text.ToUpper();
                                            ControllerInventario.Estado = cbEstado.Text;
                                            ControllerInventario.Detalles = txtDetalleEquipo.Text.ToUpper();
                                            ControllerInventario.Disponibilidad = false;
                                            ControllerInventario.departamento = cbDepartamento.Text;
                                            if (ModelInventario.InsertInventario(ControllerInventario))
                                            {
                                                MessageBox.Show("EQUIPO AGREGADO CORRECTAMENTE", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                ClearAll();
                                            }
                                            else
                                            {
                                                MessageBox.Show("ERROR AL INSERTAR ESTE EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("DEBE SELECCIONAR UN DEPARTAMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("DEBE INGRESAR EL DETALLE DEL EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("DEBE SELECCIONAR EL ESTADO DEL EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("DEBE INGRESAR EL MODELO DEL EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("DEBE INGRESAR LA MARCA DEL EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBE SELECCIONAR UN TIPO DE EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtNumeroInventarido.Text = "";
                    MessageBox.Show("ESTE NUMERO DE INVENTARIADO ESTA ASIGNADO A OTRO EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }            
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO DE INVENTARIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtNumeroInventarido_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
