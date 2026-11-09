using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Model;
using System.Diagnostics;

namespace LauncherProgram.Launchers
{
    public class ProgramLauncher : ILauncher
    {
        public LauncherSystem System => LauncherSystem.Program;

        public void Execute(HotkeyProgram program)
        {
            if (string.IsNullOrWhiteSpace(program.Commands))
                throw new ArgumentException("Program path cannot be empty.");

            Process.Start(new ProcessStartInfo
            {
                FileName = program.Commands,
                UseShellExecute = true
            });
        }
    }
}