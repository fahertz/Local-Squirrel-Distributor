using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor.Customization
{
    public class CustomMessage
    {
        public static void Error(string text= "Error to complete the task.", string caption ="Error")
        {
            MessageBox.Show(text,caption,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
