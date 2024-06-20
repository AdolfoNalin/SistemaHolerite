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

        public static void Message(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public static string LikeString(string text)
        {
            return "%" + text + "%";
        }
    }
}
