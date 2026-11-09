using LauncherProgram.Enum;
using LauncherProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LauncherProgram.Interface
{
    public interface ILauncher
    {
        LauncherSystem System { get; }

        void Execute(HotkeyProgram program);
    }
}
