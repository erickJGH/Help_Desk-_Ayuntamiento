using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_CEA_SYSTEM.Controller
{
    class cInventario
    {        
        public string SQL { get; set; }
        public int idInventario { get; set; }
        public string NumeroInventario { get; set; }
        public string Equipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Estado { get; set; }
        public string departamento { get; set; }
        public string ip { get; set; }
        public string mac { get; set; }
        public string empleado { get; set; }
        public string Detalles { get; set; }
        public bool Disponibilidad { get; set; }
        public DataGridView Tabla { get; set; }
        public ComboBox ComboBox { get; set; }        
    }
}
