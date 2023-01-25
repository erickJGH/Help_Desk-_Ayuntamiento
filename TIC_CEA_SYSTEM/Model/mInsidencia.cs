using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIC_CEA_SYSTEM.Controller;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using TIC_CEA_SYSTEM.View;
using System.Collections;

namespace TIC_CEA_SYSTEM.Model
{
    
    class mInsidencia:Conexion
    {
        string SQL;                
        SqlDataAdapter DataAdapter;
        SqlCommand Comando;
        DataTable Datatable;        
        SqlDataReader DatasRead;
        int Ticket;
        public void ShowInsidencias(cInsidencia Insidencia)
        {           
            try
            {
                Conneted.Open();
                DataAdapter = new SqlDataAdapter(Insidencia.SQL, Conneted);
                Datatable = new DataTable();
                DataAdapter.Fill(Datatable);
                Insidencia.NombreTabla.DataSource = Datatable;
                Conneted.Close();               
            }
            catch (Exception)
            {                
                Conneted.Close();                
            }                                                                                            
        }

        public int ShowNumberTicket()
        {            
            SQL = "SELECT MAX(idIncidencia) FROM Incidencia";
            Conneted.Open();
            try
            {
                Comando = new SqlCommand(SQL, Conneted);
                DatasRead = Comando.ExecuteReader();                
                while (DatasRead.Read())
                {
                    if (DatasRead.IsDBNull(0))
                    {
                        Ticket = 1;
                        Conneted.Close();
                        return Ticket;
                    }
                    else
                    {
                        Ticket = DatasRead.GetInt32(0) + 1;
                        Conneted.Close();
                        return Ticket;
                    }                   
                }
                Conneted.Close();
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en:ticket " + e.Message);
                Conneted.Close();
                return 0;
            }
        }

        public void ShowCombobox(cInsidencia Insidencia)
        {            
            Conneted.Open();
            try
            {                
                Comando = new SqlCommand(Insidencia.SQL, Conneted);
                DatasRead = Comando.ExecuteReader();
                while (DatasRead.Read())
                {                                        
                    Insidencia.ComboBox.Items.Add(DatasRead.GetSqlString(0));
                }
                Conneted.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en: show combobox"+e.Message);
                Conneted.Close();
            }
        }
              
        public bool insertInsidencia(cInsidencia Insidencia)
        {                     
            try
            {                
                Conneted.Open();
                Comando = new SqlCommand(Insidencia.SQL, Conneted);
                
                Comando.Parameters.AddWithValue("@Departamento", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Extencion", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Reportante", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Detalle", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Categoria", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Tipo", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@IdSoporte", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@Componente", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@PersonaAsignacion", SqlDbType.NVarChar);

                Comando.Parameters["@Departamento"].Value = Insidencia.Departamento;                
                Comando.Parameters["@Extencion"].Value = Insidencia.ExtensionDepartamento;                
                Comando.Parameters["@Reportante"].Value = Insidencia.UsuarioReportante;                
                Comando.Parameters["@Detalle"].Value = Insidencia.DetalleInsidencia;                
                Comando.Parameters["@Categoria"].Value = Insidencia.CategoriaInsidencia;                
                Comando.Parameters["@Tipo"].Value = Insidencia.TipoInsidencia;                
                Comando.Parameters["@IdSoporte"].Value = Insidencia.NombreSoporte;                
                Comando.Parameters["@Componente"].Value = Insidencia.EquipoComponente;
                Comando.Parameters["@PersonaAsignacion"].Value = Insidencia.PersonaAsignante;

                Comando.ExecuteNonQuery();                
                Conneted.Close();
                return true;
            }
            catch (Exception E)
            {
                
                MessageBox.Show("error en: el insert"+E.Message);
                Conneted.Close();
                return false;

            }
            
        }

        public bool DeleteIncidencia(cInsidencia Insidencia)
        {
            SQL = "DELETE FROM Incidencia WHERE idIncidencia = @IDincidencias";
            try
            {
                Conneted.Open();
                Comando = new SqlCommand(SQL, Conneted);
                Comando.Parameters.AddWithValue("@IDincidencias", Insidencia.idInsidecias);
                Comando.ExecuteNonQuery();
                Conneted.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en: el delete " + e.Message);
                Conneted.Close();
                return false;
            }
        }

        public bool UpdateIncidencia(cInsidencia Insidencia)
        {
            try
            {                              
                Conneted.Open();
                Comando = new SqlCommand(Insidencia.SQL, Conneted);
                Comando.Parameters.AddWithValue("@nombreDepartamento", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Extencion", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Reportante", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Detalle", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Categorie", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@tipo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Soporte", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@equipo", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Estatus", SqlDbType.Bit);
                Comando.Parameters.AddWithValue("@idIncidencia", SqlDbType.Int);
                Comando.Parameters.AddWithValue("@Solucion", SqlDbType.NVarChar);                
                Comando.Parameters.AddWithValue("@pieza", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Colaborador", SqlDbType.NVarChar);                

                Comando.Parameters["@nombreDepartamento"].Value = Insidencia.Departamento;
                Comando.Parameters["@Extencion"].Value = Insidencia.ExtensionDepartamento;
                Comando.Parameters["@Reportante"].Value = Insidencia.UsuarioReportante;
                Comando.Parameters["@Detalle"].Value = Insidencia.DetalleInsidencia;
                Comando.Parameters["@Categorie"].Value = Insidencia.CategoriaInsidencia;
                Comando.Parameters["@tipo"].Value = Insidencia.TipoInsidencia;
                Comando.Parameters["@Soporte"].Value = Insidencia.NombreSoporte;
                Comando.Parameters["@equipo"].Value = Insidencia.EquipoComponente;
                Comando.Parameters["@Estatus"].Value = Insidencia.EstatudInsidencia;
                Comando.Parameters["@idIncidencia"].Value = Insidencia.idInsidecias;
                Comando.Parameters["@Solucion"].Value = Insidencia.Solucion;                
                Comando.Parameters["@pieza"].Value = Insidencia.Pieza;
                Comando.Parameters["@Colaborador"].Value = Insidencia.PersonaColaboracion;
                Comando.ExecuteNonQuery();                
                Conneted.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en:update " + e.Message);
                Conneted.Close();
                return false;
            }
        }

    }
}
