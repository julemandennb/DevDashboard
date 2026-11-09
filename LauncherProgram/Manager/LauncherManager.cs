using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Launchers;
using LauncherProgram.Model;
using System;
using System.Collections.Generic;

namespace LauncherProgram.Manager
{
    public class LauncherManager
    {
        private readonly Dictionary<LauncherSystem, ILauncher> _launchers = new();

        public LauncherManager()
        {
            RegisterDefaults();
        }

        private void RegisterDefaults()
        {
            Register(new ProgramLauncher());
            Register(new WebsiteLauncher());
            Register(new FolderLauncher());
            Register(new CommandLauncher());
        }

        public void Register(ILauncher launcher)
        {
            if (launcher == null)
                throw new ArgumentNullException(nameof(launcher));

            _launchers[launcher.System] = launcher;
        }

        public bool Unregister(LauncherSystem system)
        {
            return _launchers.Remove(system);
        }

        public bool IsRegistered(LauncherSystem system)
        {
            return _launchers.ContainsKey(system);
        }

        public bool Execute(HotkeyProgram program)
        {
            if (program == null)
                throw new ArgumentNullException(nameof(program));

            if (!_launchers.TryGetValue(
                program.Launcher, out ILauncher? launcher))
                return false;

            launcher.Execute(program);

            return true;
        }
    }
}