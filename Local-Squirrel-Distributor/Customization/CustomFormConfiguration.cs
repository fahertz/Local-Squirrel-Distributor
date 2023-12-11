using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor.Customization
{
    public static class CustomFormConfiguration
    {
        public static void toDefaultForm(this Form form)
        {
            form.MaximumSize = new Size(form.Width, form.Height);
            form.MinimumSize = new Size(form.Width, form.Height);
        }
    }
}
