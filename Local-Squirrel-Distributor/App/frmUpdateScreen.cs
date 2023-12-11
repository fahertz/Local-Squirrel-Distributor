using Local_Squirrel_Distributor.App;
using Local_Squirrel_Distributor.Configuration;
using Local_Squirrel_Distributor.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor
{
    public partial class frmUpdateScreen : Form
    {
        public frmUpdateScreen()
        {
            InitializeComponent();
            ConfigureFormProperties();
            ConfigureFormEvents();
        }

        /** Async Taks  **/
        private async Task updateApplicationAsync()
        {
            try
            {
                UpdateUIForSearchingUpdates();
                if (await UpdateSquirrel.DownloadReleaseAsync(UpdateSquirrel._updateUrl))
                {
                    UpdateUIForDownloadComplete();
                    if (await UpdateSquirrel.InstallReleaseAsync(UpdateSquirrel._updateUrl))
                    {
                        UpdateUIForInstallComplete();
                        if (await UpdateSquirrel.UpdateAppAsync(UpdateSquirrel._updateUrl))
                        {
                            UpdateUIForUpdateComplete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                Console.WriteLine($"Error during update: {ex.Message}");
            }
            finally
            {
                await Task.Delay(5000);
                UpdateSquirrel.RestartApplication();
            }

        }

        /** Sync Methods **/
        private void UpdateUIForSearchingUpdates()
        {
            lblSearchingForUpdates.Text = $"Version: {UpdateSquirrel.nextVersion} detected. ({Application.ProductVersion} → {UpdateSquirrel.nextVersion})";
            UpdateButtonStyle(pcbSearchingForUpdates);
        }
        private void UpdateUIForDownloadComplete()
        {
            lblDownload.Text = "Download Completed.";
            UpdateButtonStyle(pcbDownload);
        }
        private void UpdateUIForInstallComplete()
        {
            lblInstall.Text = "Install Completed.";
            UpdateButtonStyle(pcbInstall);
        }
        private void UpdateUIForUpdateComplete()
        {
            lblUpdate.Text = "Update Completed.";
            UpdateButtonStyle(pcbUpdate);
        }
        private void UpdateButtonStyle(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Green_Button;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmUpdateScreen_Load;
        }
        private void ConfigureFormProperties()
        {
            this.toDefaultForm();
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
            
            pcbDownload.BackgroundImage = Properties.Resources.Red_Button;
            pcbDownload.BackgroundImageLayout = ImageLayout.Stretch;
            
            pcbInstall.BackgroundImage = Properties.Resources.Red_Button;
            pcbInstall.BackgroundImageLayout = ImageLayout.Stretch;

            pcbUpdate.BackgroundImage = Properties.Resources.Red_Button;
            pcbUpdate.BackgroundImageLayout = ImageLayout.Stretch;

        }
    }
}
