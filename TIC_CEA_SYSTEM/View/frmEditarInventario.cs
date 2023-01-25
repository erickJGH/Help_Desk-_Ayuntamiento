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
    public partial class frmEditarInventario : Form
    {
        mInventario ModelInventario = new mInventario();
        cInventario ControllerInventario = new cInventario();        
        public void ShowPC()
        {
            ControllerInventario.SQL = "SELECT idInventario AS NUMERO,NumeroInventariado AS INVENTARIADO,TipoEquipo AS TIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTADO,DescripcionEquipo AS DESCRIPCION,(SELECT DeparmentName FROM Deparment where idDeparment = Departamento) AS DEPARTAMENTO FROM Inventario";
            ControllerInventario.Tabla = dgvConfigurarRemoto;
            ModelInventario.ShowInventario(ControllerInventario);
            dgvConfigurarRemoto.Columns[0].Visible = false;                       
        }
        public void Cancel()
        {
            txtNumeroInventarido.Enabled = false;
            cbEquipo.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            cbEstado.Enabled = false;
            txtDetalleEquipo.Enabled = false;

            txtNumeroInventarido.Text = "";
            cbEquipo.Items.Clear();
            txtMarca.Text = "";
            txtModelo.Text = "";
            cbEstado.Items.Clear();
            txtDetalleEquipo.Text = "";

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;

            btnSave.BackColor = Color.DarkGray;
            btnDelete.BackColor = Color.DarkGray;
            btnCancel.BackColor = Color.DarkGray;
        }
        public frmEditarInventario()
        {
            InitializeComponent();
            txtIdInventario.Visible = false;
            txtNumeroInventarido.Enabled = false;
        }
        private void frmEditarRemoto_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Cancel();
            ShowPC();            
        }
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            txtBuscarConfig.Text = "";
            ShowPC();            
        }
        private void txtBuscarConfig_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscarConfig.Text != "")
            {
                ControllerInventario.SQL = "SELECT idInventario AS NUMERO,NumeroInventariado AS INVENTARIADO,TipoEquipo AS TIPO,Marca AS MARCA,Modelo AS MODELO,Estado AS ESTADO,DescripcionEquipo AS DESCRIPCION,(SELECT DeparmentName FROM Deparment where idDeparment = Departamento) AS DEPARTAMENTO FROM Inventario WHERE TipoEquipo LIKE '%" + txtBuscarConfig.Text + "%'";                
                ControllerInventario.Tabla = dgvConfigurarRemoto;
                ModelInventario.ShowInventario(ControllerInventario);
                dgvConfigurarRemoto.Columns[0].Visible = false;
            }
            else
            {
                ShowPC();                
            }
        }
        private void dgvConfigurarRemoto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {                
                cbEquipo.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                cbEstado.Enabled = true;
                txtDetalleEquipo.Enabled = true;

                txtNumeroInventarido.Text = "";
                cbEquipo.Items.Clear();
                txtMarca.Text = "";
                txtModelo.Text = "";
                cbEstado.Items.Clear();
                txtDetalleEquipo.Text = "";

                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;

                btnSave.BackColor = Color.White;
                btnDelete.BackColor = Color.White;
                btnCancel.BackColor = Color.White;

                //SELECT Estado AS ESTADO FROM Inventario
                DataGridViewRow dvgConfig = dgvConfigurarRemoto.Rows[e.RowIndex];
                txtIdInventario.Text = dvgConfig.Cells[0].Value.ToString();
                txtNumeroInventarido.Text = dvgConfig.Cells[1].Value.ToString();
                cbEquipo.Items.Add(dvgConfig.Cells[2].Value.ToString());
                cbEquipo.SelectedIndex = 0;
                txtMarca.Text = dvgConfig.Cells[3].Value.ToString();
                txtModelo.Text = dvgConfig.Cells[4].Value.ToString();
                cbEstado.Items.Add(dvgConfig.Cells[5].Value.ToString());
                cbEstado.SelectedIndex = 0;
                txtDetalleEquipo.Text = dvgConfig.Cells[6].Value.ToString();

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
            }
            else
            {
                MessageBox.Show("ESTA NO ES UNA OPCION VALIDA","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }                


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR ESTE ARTICULO DEL INVENTARIO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(txtIdInventario.Text);
                ControllerInventario.idInventario = ID;
                if (ModelInventario.DeleteInventario(ControllerInventario))
                {
                    MessageBox.Show("ARTICULO BORRADO CON EXITO", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Cancel();
                    ShowPC();
                }
                else
                {
                    MessageBox.Show("ERROR AL INENTAR ELIMINAR ESTE REMOTO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {            
            DialogResult Answer = MessageBox.Show("ESTA SEGURO QUE DESEA GUARDAR ESTOS NUEVOS CAMBIOS?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Answer == DialogResult.Yes)
            {
                if (txtNumeroInventarido.Text != "")
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
                                        ControllerInventario.SQL = "UPDATE Inventario set TipoEquipo = @Equipo,Marca = @Marcar,Modelo = @Modelo,Estado = @Estado,DescripcionEquipo =@Detalles,Disponibilidad= @Disponibilidad  WHERE idInventario = @idInventario";
                                        int ID = Convert.ToInt32(txtIdInventario.Text);
                                        ControllerInventario.idInventario = ID;
                                        ControllerInventario.NumeroInventario = "";
                                        ControllerInventario.Equipo = cbEquipo.Text;
                                        ControllerInventario.Marca = txtMarca.Text.ToUpper();
                                        ControllerInventario.Modelo = txtModelo.Text.ToUpper();
                                        ControllerInventario.Estado = cbEstado.Text;
                                        ControllerInventario.Detalles = txtDetalleEquipo.Text.ToUpper();
                                        ControllerInventario.Disponibilidad = true;
                                        ControllerInventario.departamento = "";
                                        ControllerInventario.empleado = "";
                                        ControllerInventario.ip = "";
                                        ControllerInventario.mac = "";
                                        if (ModelInventario.UpdateInventario(ControllerInventario))
                                        {
                                            Cancel();
                                            ShowPC();
                                            MessageBox.Show("EL ARTICULO FUE MODIFICADO CON EXITO", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        }
                                        else
                                        {
                                            MessageBox.Show("ERROR AL INTENTAR MODIFICAR ESTE ARTICULO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("DEBE AGREGAR DETALLES DEL EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("DEBE SELECCIONA EL TIPO DE EQUIPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR EL NUMERO DE INVENTARIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ShowPC();
        }
    }
}
