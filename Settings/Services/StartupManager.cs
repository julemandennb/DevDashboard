using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace Settings.Services
{
    public static class StartupManager
    {
        private const string AppName = "julemandennb.DevDashboard";

        private const string WindowsRunKey =
            @"Software\Microsoft\Windows\CurrentVersion\Run";

        private static string LinuxAutostartFile =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".config",
                "autostart",
                $"{AppName}.desktop"
            );

        public static bool IsSupported =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ||
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        public static bool IsStartWithPCEnabled()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using var key = Registry.CurrentUser.OpenSubKey(WindowsRunKey);

                return key?.GetValue(AppName) != null;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return File.Exists(LinuxAutostartFile);
            }

            return false;
        }

        public static void SetStartWithPC(bool enabled)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                SetWindowsStartup(enabled);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                SetLinuxStartup(enabled);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Startup configuration is not supported on this platform."
                );
            }
        }

        private static void SetWindowsStartup(bool enabled)
        {
            using var key = Registry.CurrentUser.OpenSubKey(
                WindowsRunKey, writable: true)
                ?? Registry.CurrentUser.CreateSubKey(WindowsRunKey);

            if (enabled)
            {
                string? appPath = Environment.ProcessPath;

                if (string.IsNullOrEmpty(appPath))
                    throw new InvalidOperationException("Application path not found.");

                key.SetValue(AppName, $"\"{appPath}\"");
            }
            else
            {
                key.DeleteValue(AppName, false);
            }
        }

        private static void SetLinuxStartup(bool enabled)
        {
            if (enabled)
            {
                string? appPath = Environment.ProcessPath;

                if (string.IsNullOrEmpty(appPath))
                    throw new InvalidOperationException("Application path not found.");

                string directory = Path.GetDirectoryName(LinuxAutostartFile)!;

                Directory.CreateDirectory(directory);

                string escapedPath = appPath.Replace("\\", "\\\\")
                                             .Replace("\"", "\\\"");

                string content = $"""
                [Desktop Entry]
                Type=Application
                Name=DevDashboard
                Comment=DevDashboard by julemandennb
                Exec="{escapedPath}"
                Terminal=false
                X-GNOME-Autostart-enabled=true
                """;

                File.WriteAllText(LinuxAutostartFile, content);
            }
            else
            {
                if (File.Exists(LinuxAutostartFile))
                    File.Delete(LinuxAutostartFile);
            }
        }
    }
}
