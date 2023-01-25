using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_CEA_SYSTEM.Controller
{
    class cPersona
    {
        public string SQL { get; set; }
        public int idPersona { get; set; }
        public string Nombres { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }        
        public string usuario { get; set; }
        public string password { get; set; }
        public string privilegio { get; set; }
        public bool estado { get; set; }
        public string fechaCreacion { get; set; }
        public string Lastlogin { get; set; }
        public ComboBox ComboBox { get; set; }        
        public DataGridView Tabla { get; set; }
    }
}
