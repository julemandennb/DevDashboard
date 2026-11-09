using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Model;
using System.Diagnostics;

namespace LauncherProgram.Launchers
{
    public class CommandLauncher : ILauncher
    {
        public LauncherSystem System => LauncherSystem.Command;

        public void Execute(HotkeyProgram program)
        {
            if (string.IsNullOrWhiteSpace(program.Commands))
                throw new ArgumentException("Command cannot be empty.");

            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + program.Commands,
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
    }
}