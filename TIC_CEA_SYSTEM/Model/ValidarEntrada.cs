using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_CEA_SYSTEM.Model
{
    class ValidarEntrada
    {
        public  void ValidarLetrar(KeyPressEventArgs L)
        {
            if (Char.IsLetter(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsSeparator(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsControl(L.KeyChar))
            {
                L.Handled = false;
            }
            else
            {
                L.Handled = true;
                MessageBox.Show("Solo esta permitido indtroducir letras en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public  void ValidarSoloNumero(KeyPressEventArgs L)
        {
            if (Char.IsDigit(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsSeparator(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (char.IsControl(L.KeyChar))
            {
                L.Handled = false;
            }
            else if (L.KeyChar.ToString().Equals("-"))
            {
                L.Handled = false;
            }
            else
            {
                L.Handled = true;
                MessageBox.Show("Solo esta permitido indtroducir numeros con guiones en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
