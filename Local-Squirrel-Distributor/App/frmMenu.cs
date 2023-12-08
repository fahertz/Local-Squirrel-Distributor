using Local_Squirrel_Distributor.Configuration;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            btnRollback.Click += btnRollback_Click;
            ConfigureTextBoxProperties();
            ConfigureFormEvents();
        }

        private async void btnRollback_Click(object sender, EventArgs e)
        {
            rollbackApplicationAsync();            
        }
        static async Task DownloadFileAsync(string url, string outputPath)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    response.EnsureSuccessStatusCode();
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(outputPath, fileBytes);
                }
            }
        }
        private void rollbackApplicationAsync()
        {
            try
            {                
                string localFilePath = @"C:\Local-Squirrel-Distributor\Rollback\Setup.exe";                
                Process.Start(localFilePath);
                Environment.Exit(0);                

            }
            catch
            {

            }            

        }


        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmMenu_Load;
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtProgramVersion.Text = Application.ProductVersion;
        }


        /** TextBox Configuration **/
        private void ConfigureTextBoxProperties()
        {

            txtProgramVersion.ReadOnly = true;
            txtProgramVersion.TabStop = false ;
        }
    }
}
