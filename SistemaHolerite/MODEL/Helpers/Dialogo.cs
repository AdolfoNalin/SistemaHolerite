using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL.Helpers
{
    public class Dialogo
    {
        public static DialogResult DialogYesNo(string title, string message)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result;
        }
    }
}
