using Local_Squirrel_Distributor.Configuration;
using Local_Squirrel_Distributor.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor.App
{
    public partial class frmMenu : CustomForm
    {
        public frmMenu()
        {
            InitializeComponent();
            ConfigureFormProperties();

            ConfigureTextBoxProperties();
            
            
            
            ConfigureFormEvents();


            
        }
        private void btnRollback_Click(object sender, EventArgs e)
        {
            rollbackApplicationAsync();            
        }        
        private void rollbackApplicationAsync()
        {
            try
            {
                /**To perform a rollback in the application, 
                 * it is necessary to point the path below to the previous executable;
                 * it will install the version to which it was pointed. 
                 * If, for some reason, an error occurs during the reinstallation, 
                 * there is a risk that the computer may lose the application, 
                 * requiring a reinstall. Remember to delete the later versions 
                 * from the 'RELEASES' file; if you forget to do this, 
                 * the application will update as soon as a lower version
                 * is detected.**/

                string localFilePath = @"C:\Local-Squirrel-Distributor\Rollback\Setup.exe";  /**Place your local rollback folder**/              
                Process.Start(localFilePath);
                Environment.Exit(0);                
            }
            catch (Exception ex)
            {
                CustomMessage.Error(ex.Message);
            }            
        }
        
        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmMenu_Load;
        }
        private void ConfigureFormProperties() 
        {
            this.toDefaultForm();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

            /** Attributes **/
            ConfigureTextBoxAttributes();



            /** Events **/
            ConfigureButtonEvents();

        }

        /** Button Configuration **/
        private void ConfigureButtonEvents()
        {
            btnRollback.Click += btnRollback_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /** TextBox Configuration **/
        private void ConfigureTextBoxProperties()
        {

            txtProgramVersion.ReadOnly = true;
            txtProgramVersion.TabStop = false ;
        }
        private void ConfigureTextBoxAttributes()
        {
            txtProgramVersion.Text = Application.ProductVersion;
        }
        
    }
}
