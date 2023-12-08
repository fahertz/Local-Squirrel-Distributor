using Local_Squirrel_Distributor.Customization;
using Squirrel;
using System;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Squirrel_Distributor.Configuration
{
    public class UpdateSquirrel
    {
        /**Squirrel Documentation https://github.com/Squirrel/Squirrel.Windows/blob/develop/docs/getting-started/2-packaging.md **/

        /** Place here the local path where your application will check for updates **/
        //public static readonly string _updateUrl = @"\\srvgeneric\Softwares\Local-Squirrel-Distributor\Releases";
        public static readonly string _updateUrl = @"C:\Local-Squirrel-Distributor\Releases";
        public static readonly string _rollackUrl = @"C:\Local-Squirrel-Distributor\Rollback";
        public static readonly bool _searchForUpdatesEnabled = true;
        public static string nextVersion { get; set; }

        public static bool CheckForUpdates()
        {
            try
            {
                if (_searchForUpdatesEnabled)
                {
                    using (var updateManager = new UpdateManager(_updateUrl))
                    {
                        var updateInfo = updateManager.CheckForUpdate().Result;

                        if (updateInfo.ReleasesToApply.Count > 0)
                        {
                            nextVersion = updateInfo.FutureReleaseEntry.Version.ToString();
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {                
                return false;
            }
            return false;
                                
        }
        
        public static async Task<bool> DownloadReleaseAsync(string path)
        {
            try
            {
                using (var updateManager = new UpdateManager(_updateUrl))
                {
                    var updateInfo = await updateManager.CheckForUpdate();
                    if (updateInfo.ReleasesToApply.Count > 0)
                    {
                        MessageBox.Show(updateInfo.FutureReleaseEntry.Version.ToString());
                        await updateManager.DownloadReleases(updateInfo.ReleasesToApply);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                CustomMessage.Error("Error to download an update release: "+ex.Message);
                return false;
            }
        }
        public static async Task<bool> InstallReleaseAsync(string path)
        {
            try
            {
                using (var updateManager = new UpdateManager(_updateUrl))
                {
                    var updateInfo = await updateManager.CheckForUpdate();
                    if (updateInfo.ReleasesToApply.Count > 0)
                    {
                        await updateManager.ApplyReleases(updateInfo);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                CustomMessage.Error("Error to Install an update release: " + ex.Message);
                return false;
            }
        }
        public static async Task<bool> UpdateAppAsync(string path)
        {
            try
            {
                using (var updateManager = new UpdateManager(_updateUrl))
                {
                    var updateInfo = await updateManager.CheckForUpdate();
                    if (updateInfo.ReleasesToApply.Count > 0)
                    {
                        await updateManager.UpdateApp();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                CustomMessage.Error("Error to Update the Application: " + ex.Message);
                return false;
            }
        }
        public static void RestartApplication()
        {
            UpdateManager.RestartApp();
        }
    }
}
