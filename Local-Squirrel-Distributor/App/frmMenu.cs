using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor.App
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            ConfigureFormEvents();
        }


        private void ConfigureFormEvents()
        {
            this.Load += frmMenu_Load;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtProgramVersion.Text = Application.ProductVersion;
        }
    }
}
