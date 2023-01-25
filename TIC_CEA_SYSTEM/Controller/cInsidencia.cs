using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_CEA_SYSTEM.Controller
{
    class cInsidencia
    {
        public string SQL { get; set; }
        public int idInsidecias { get; set; }        
        public string Pieza { get; set; }
        public string Departamento { get; set; }
        public string ExtensionDepartamento { get; set; }
        public string UsuarioReportante { get; set; }
        public string DetalleInsidencia { get; set; }
        public string CategoriaInsidencia { get; set; }
        public string TipoInsidencia { get; set; }
        public string NombreSoporte { get; set; }       
        public string EquipoComponente { get; set; }
        public string PersonaAsignante { get; set; }
        public string FechaFinal { get; set; }
        public string Solucion { get; set; }
        public string PersonaColaboracion { get; set; }
        public ComboBox ComboBox { get; set; }         
        public DataGridView NombreTabla { get; set; }
        public bool EstatudInsidencia { get; set; }               
    }
}
