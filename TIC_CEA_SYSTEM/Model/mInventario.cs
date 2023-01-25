using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIC_CEA_SYSTEM.Controller;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TIC_CEA_SYSTEM.Model
{
    class mInventario:Conexion
    {
        string SQL;
        SqlDataAdapter DataAdapter;
        SqlCommand Comando;
        DataTable Datatable;        
        SqlDataReader DatasRead;

        public bool ValidateInventarioNumber(cInventario Inventario)
        {
            SQL = "SELECT NumeroInventariado FROM Inventario";
            Conneted.Open();
            try
            {
                Comando = new SqlCommand(SQL, Conneted);
                DatasRead = Comando.ExecuteReader();
                while (DatasRead.Read())
                {                   
                    if (DatasRead.GetString(0) == Inventario.NumeroInventario)
                    {
                        Conneted.Close();
                        return false;
                    }                                                        
                }
                Conneted.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en:ticket " + e.Message);
                Conneted.Close();
                return false;
            }
        }
        public void ShowInventario(cInventario inventario)
        {
            try
            {
                Conneted.Open();
                DataAdapter = new SqlDataAdapter(inventario.SQL, Conneted);
                Datatable = new DataTable();
                DataAdapter.Fill(Datatable);
                inventario.Tabla.DataSource = Datatable;
                Conneted.Close();
            }
            catch (Exception)
            {
                Conneted.Close();
            }
        }
        public bool InsertInventario(cInventario inventario)
        {
            try
            {                
                Conneted.Open();
                Comando = new SqlCommand(inventario.SQL, Conneted);
                Comando.Parameters.AddWithValue("@NumeroInventarido", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@TipoEquipo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Marca", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Modelo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Estado", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@departamento", SqlDbType.Int);
                Comando.Parameters.AddWithValue("@Detalles", SqlDbType.Text);
                Comando.Parameters.AddWithValue("@Disponibilidad", SqlDbType.Bit);                

                Comando.Parameters["@NumeroInventarido"].Value = inventario.NumeroInventario;
                Comando.Parameters["@TipoEquipo"].Value = inventario.Equipo;
                Comando.Parameters["@Marca"].Value = inventario.Marca;
                Comando.Parameters["@departamento"].Value = inventario.departamento;
                Comando.Parameters["@Modelo"].Value = inventario.Modelo;
                Comando.Parameters["@Estado"].Value = inventario.Estado;
                Comando.Parameters["@Detalles"].Value = inventario.Detalles;
                Comando.Parameters["@Disponibilidad"].Value = inventario.Disponibilidad;

                Comando.ExecuteNonQuery();
                Conneted.Close();
                return true;
            }
            catch (Exception E)
            {

                MessageBox.Show("ERROR INSERT INVENTARIO" + E.Message);
                Conneted.Close();
                return false;

            }

        }
        public bool UpdateInventario(cInventario inventario)
        {
            try
            {
                Conneted.Open();
                Comando = new SqlCommand(inventario.SQL, Conneted);                
                Comando.Parameters.AddWithValue("@idInventario", SqlDbType.Int);
                Comando.Parameters.AddWithValue("@Equipo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Marcar", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Modelo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Estado", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Detalles", SqlDbType.Text);
                Comando.Parameters.AddWithValue("@Disponibilidad", SqlDbType.Bit);
                Comando.Parameters.AddWithValue("@Departamento", SqlDbType.Int);
                Comando.Parameters.AddWithValue("@Empleado", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Ip", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Mac", SqlDbType.NVarChar);                

                Comando.Parameters["@idInventario"].Value = inventario.idInventario;
                Comando.Parameters["@Equipo"].Value = inventario.Equipo;
                Comando.Parameters["@Marcar"].Value = inventario.Marca;
                Comando.Parameters["@Modelo"].Value = inventario.Modelo;
                Comando.Parameters["@Estado"].Value = inventario.Estado;
                Comando.Parameters["@Detalles"].Value = inventario.Detalles;
                Comando.Parameters["@Disponibilidad"].Value = inventario.Disponibilidad;
                Comando.Parameters["@Departamento"].Value = inventario.departamento;
                Comando.Parameters["@Empleado"].Value = inventario.empleado;
                Comando.Parameters["@Ip"].Value = inventario.ip;
                Comando.Parameters["@Mac"].Value = inventario.mac;
                Comando.ExecuteNonQuery();
                Conneted.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("error al insertar el inventario");
                Conneted.Close();                
                return false;
            }
        }
        public bool DeleteInventario(cInventario inventario)
        {
            SQL = "DELETE FROM Inventario WHERE idInventario = @idInventario";
            try
            {
                Conneted.Open();
                Comando = new SqlCommand(SQL, Conneted);
                Comando.Parameters.AddWithValue("@idInventario", inventario.idInventario);
                Comando.ExecuteNonQuery();
                Conneted.Close();
                return true;
            }
            catch (Exception)
            {
                Conneted.Close();
                return false;
            }
        }

    }
}
