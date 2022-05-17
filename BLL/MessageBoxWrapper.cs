using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class MessageBoxWrapper
    {
        public static bool IsOpen { get; set; }
        public static void Show(string messageBoxText, string caption)
        {
            IsOpen = true;
            MessageBox.Show(messageBoxText, caption);
            IsOpen = false;
        }
    }
}
