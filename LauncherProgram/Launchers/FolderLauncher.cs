using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Model;
using System.Diagnostics;
using System.IO;

namespace LauncherProgram.Launchers
{
    public class FolderLauncher : ILauncher
    {
        public LauncherSystem System => LauncherSystem.Folder;

        public void Execute(HotkeyProgram program)
        {
            if (!Directory.Exists(program.Commands))
                throw new DirectoryNotFoundException(
                    $"Folder not found: {program.Commands}");

            Process.Start(new ProcessStartInfo
            {
                FileName = program.Commands,
                UseShellExecute = true
            });
        }
    }
}