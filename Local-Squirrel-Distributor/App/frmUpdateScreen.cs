﻿using Local_Squirrel_Distributor.App;
using Local_Squirrel_Distributor.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor
{
    public partial class frmUpdateScreen : Form
    {
        public frmUpdateScreen()
        {
            InitializeComponent();
            ConfigureFormEvents();
        }


        /** Async Taks  **/
        private async Task updateApplicationAsync()
        {
            try
            {
                if (UpdateSquirrel.CheckForUpdates())
                {
                    lblSearchingForUpdates.Text = $"Version: {UpdateSquirrel.nextVersion} detectada. ({Application.ProductVersion} → {UpdateSquirrel.nextVersion})";
                    if (await UpdateSquirrel.DownloadReleaseAsync())
                    {
                        lblDownload.Text = $"Download Completed.";
                        pcbDownload.BackgroundImage = Properties.Resources.Green_Button;
                        pcbDownload.BackgroundImageLayout = ImageLayout.Stretch;
                        if (await UpdateSquirrel.InstallReleaseAsync())
                        {
                            lblInstall.Text = $"Install Completed.";
                            pcbInstall.BackgroundImage = Properties.Resources.Green_Button;
                            pcbInstall.BackgroundImageLayout = ImageLayout.Stretch;
                            if (await UpdateSquirrel.UpdateAppAsync())
                            {
                                lblUpdate.Text = $"Update Completed.";
                                pcbUpdate.BackgroundImage = Properties.Resources.Green_Button;
                                pcbUpdate.BackgroundImageLayout = ImageLayout.Stretch;
                                UpdateSquirrel.RestartApplication();
                            };
                        };
                    }

                }
                else
                {
                    lblSearchingForUpdates.Text = $"Nenhuma nova versão detectada.";
                    pcbSearchingForUpdates.BackgroundImage = Properties.Resources.Green_Button;
                    pcbSearchingForUpdates.BackgroundImageLayout = ImageLayout.Stretch;
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                    this.Close();
                }
            }
            catch
            {
                
            }
                
        }



        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmUpdateScreen_Load;
        }
        private async void frmUpdateScreen_Load(object sender, EventArgs e)
        {
            ConfigurePictureBoxAttributes();
            await updateApplicationAsync();
        }


        /** PictureBox Configuration **/
        private void ConfigurePictureBoxAttributes()
        {
            pcbSearchingForUpdates.BackgroundImage = Properties.Resources.Red_Button;
            pcbSearchingForUpdates.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}