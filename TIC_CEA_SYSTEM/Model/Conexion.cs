using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TIC_CEA_SYSTEM.Model
{
    class Conexion
    {
        static public SqlConnection Conneted;
        public Conexion()
        {
            if (Conneted == null)
            {
                try
                {
                
                    Conneted = new SqlConnection("Data Source=Computos-03;Initial Catalog=HelpDeskSoporte;Persist Security Info=True;User ID=sa;Password=Computos22SF");                    
                }
                catch (SqlException ex)
                {
                    Conneted = null;
                    MessageBox.Show("ERROR EN LA CONEXION DE LA BASE DE DATOS "+ ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            

        }
    }
}
