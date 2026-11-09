using LauncherProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LauncherProgram.Interface
{
    public interface IGlobalHotkeyManager : IDisposable
    {
        event Action<HotkeyProgram>? HotkeyPressed;

        bool Register(HotkeyProgram hotkey);

        bool Unregister(HotkeyProgram hotkey);

        void UnregisterAll();
    }
}
