using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Local_Squirrel_Distributor.App;
using Local_Squirrel_Distributor.Configuration;
using Squirrel;

namespace Local_Squirrel_Distributor
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (UpdateSquirrel.CheckForUpdates())
            {
                Application.Run(new frmUpdateScreen());
            }
            else
            {
                Application.Run(new frmMenu());
            }
            
        }
    }
}
