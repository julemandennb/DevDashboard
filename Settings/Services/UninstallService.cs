using System;
using System.IO;

namespace Settings.Services
{
    public static class UninstallService
    {
        public static void Cleanup()
        {
            try
            {
                // Disable Start with PC
                StartupManager.SetStartWithPC(false);

                // Remove DevDashboard AppData
                string rootPath = PathServices.RootPath;

                if (Directory.Exists(rootPath))
                {
                    Directory.Delete(rootPath, recursive: true);
                }
            }
            catch (Exception ex)
            {
                // Log uninstall cleanup error
                File.AppendAllText(
                    Path.Combine(Path.GetTempPath(), "DevDashboard-Uninstall.log"),
                    $"{DateTime.Now}: {ex}\n"
                );
            }
        }
    }
}