using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Model;
using System.Diagnostics;

namespace LauncherProgram.Launchers
{
    public class WebsiteLauncher : ILauncher
    {
        public LauncherSystem System => LauncherSystem.Website;

        public void Execute(HotkeyProgram program)
        {
            if (!Uri.TryCreate(
                program.Commands,
                UriKind.Absolute,
                out Uri? uri) ||
                (uri.Scheme != Uri.UriSchemeHttp &&
                 uri.Scheme != Uri.UriSchemeHttps))
            {
                throw new ArgumentException("Invalid website URL.");
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = uri.AbsoluteUri,
                UseShellExecute = true
            });
        }
    }
}