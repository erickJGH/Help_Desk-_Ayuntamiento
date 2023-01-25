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

namespace TIC_CEA_SYSTEM.Model
{
    class mPersona:Conexion
    {
        string SQL;
        SqlDataAdapter DataAdapter;
        SqlCommand Comando;
        DataTable Datatable;        
        SqlDataReader DatasRead;
        Encrypt Encriptar = new Encrypt();
        string Pass;
        public void ShowPersona(cPersona Persona)
        {
            try
            {
                Conneted.Open();
                DataAdapter = new SqlDataAdapter(Persona.SQL, Conneted);
                Datatable = new DataTable();
                DataAdapter.Fill(Datatable);
                Persona.Tabla.DataSource = Datatable;
                Conneted.Close();
            }
            catch (Exception)
            {
                Conneted.Close();
            }
        }       
    
        public bool ShowUsuario(cPersona Persona)
        {            
            Conneted.Open();
            try
            {
                Comando = new SqlCommand(Persona.SQL, Conneted);
                DatasRead = Comando.ExecuteReader();
                while (DatasRead.Read())
                {
                    if (Persona.ComboBox != null)
                    {
                        Persona.ComboBox.Items.Add(DatasRead.GetString(0));                        
                    }
                    else if (DatasRead.GetString(0).Equals(Persona.usuario))
                    {
                        Conneted.Close();
                        return false;
                    }
                }
                Conneted.Close();
                return true;
            }
            catch (Exception E)
            {
                Conneted.Close();
                MessageBox.Show(E.Message);
                return false;
            }
        }

        public bool InsertPersona(cPersona Persona)
        {
            
            
            try
            {
                Pass = Encriptar.Encryptions(Persona.password);
                Conneted.Open();
                Comando = new SqlCommand(Persona.SQL, Conneted);                

                Comando.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@cedula", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@usuario", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@password", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@privilegio", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@Estado", SqlDbType.Bit);
            
                

                Comando.Parameters["@Nombre"].Value = Persona.Nombres;
                Comando.Parameters["@apellido"].Value = Persona.apellidos;
                Comando.Parameters["@cedula"].Value = Persona.cedula;
                Comando.Parameters["@usuario"].Value = Persona.usuario;
                Comando.Parameters["@password"].Value = Pass;
                Comando.Parameters["@privilegio"].Value = Persona.privilegio;
               



                Comando.ExecuteNonQuery();
                Conneted.Close();
                return true;
            }
            catch (Exception E)
            {

                MessageBox.Show("ERROR AL REPORTAR ESTA INSIDENCIA" + E.Message);
                Conneted.Close();
                return false;

            }

        }

        public bool UpdatePersona(cPersona Persona)
        {
            Pass = Encriptar.Encryptions(Persona.password);
            try
            {
                
                Conneted.Open();
                Comando = new SqlCommand(Persona.SQL, Conneted);
                Comando.Parameters.AddWithValue("@idEmpleado", SqlDbType.Int);
                Comando.Parameters.AddWithValue("@Password", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@User", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@cedula", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@privilegio", SqlDbType.NVarChar);
                Comando.Parameters.AddWithValue("@estado", SqlDbType.Bit);                


                Comando.Parameters["@Password"].Value = Pass;
                Comando.Parameters["@User"].Value = Persona.usuario;
                Comando.Parameters["@idEmpleado"].Value = Persona.idPersona;
                Comando.Parameters["@nombre"].Value = Persona.Nombres;
                Comando.Parameters["@apellido"].Value = Persona.apellidos;
                Comando.Parameters["@cedula"].Value = Persona.cedula;
                Comando.Parameters["@privilegio"].Value = Persona.privilegio;
                Comando.Parameters["@estado"].Value = Persona.estado;                

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

        public bool DeletePersona(cPersona Persona)
        {
            SQL = "DELETE FROM Person WHERE idPerson = @idPersona";
            try
            {
                Conneted.Open();
                Comando = new SqlCommand(SQL, Conneted);
                Comando.Parameters.AddWithValue("@idPersona", Persona.idPersona);
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
