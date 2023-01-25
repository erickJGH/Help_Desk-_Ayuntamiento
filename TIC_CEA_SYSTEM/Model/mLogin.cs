using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using TIC_CEA_SYSTEM.Controller;


namespace TIC_CEA_SYSTEM.Model
{
    class mLogin:Conexion
    {        
        SqlCommand Comando;
        SqlDataReader DatasRead;
        cPersona Result;        
        string User, pass;
        public cPersona Authentichate(cPersona Login)
        {
            Encrypt Encriptar = new Encrypt();            
            Result = new cPersona();            
            string PasswordEncriptado = Encriptar.Encryptions(Login.password);            
                Conneted.Open();
                try
                {
                    Comando = new SqlCommand(Login.SQL, Conneted);
                    try
                    {
                        DatasRead = Comando.ExecuteReader();
                        while (DatasRead.Read())
                        {
                            User = DatasRead.GetString(3);
                            if (User.Equals(Login.usuario))
                            {
                                pass = DatasRead.GetString(4);
                                if (pass.Equals(PasswordEncriptado))
                                {
                                    Result.idPersona = DatasRead.GetInt32(0);
                                    Result.Nombres = DatasRead.GetString(1);
                                    Result.apellidos = DatasRead.GetString(2);
                                    Result.usuario = DatasRead.GetString(3);
                                    Result.password = DatasRead.GetString(4);
                                    Result.privilegio = DatasRead.GetString(5);
                                    Result.estado = DatasRead.GetBoolean(6);
                                    Conneted.Close();
                                    return Result;
                                }
                                else
                                {
                                    Result.idPersona = 0;
                                    Result.Nombres = null;
                                    Result.apellidos = null;
                                    Result.apellidos = null;
                                    Result.usuario = DatasRead.GetString(3);
                                    Result.privilegio = null;
                                    Result.estado = false;
                                    Conneted.Close();
                                    return Result;
                                }
                            }
                        }
                        Result.idPersona = 0;
                        Result.Nombres = null;
                        Result.apellidos = null;
                        Result.apellidos = null;
                        Result.usuario = "";
                        Result.privilegio = null;
                        Result.estado = false;
                        Conneted.Close();
                        return Result;
                    }
                    catch (Exception ex)
                    {
                        Conneted.Close();
                        MessageBox.Show("SE HA ENCONTRADO UN ERROR EN LA CONEXION A LA BASE DE DATOS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Result;
                    }

                }
                catch (SqlException ex)
                {
                    Conneted.Close();
                    MessageBox.Show("SE HA ENCONTRADO UN ERROR EN LA CONEXION A LA BASE DE DATOS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Result;
                }
            
            
        }


    }
}
