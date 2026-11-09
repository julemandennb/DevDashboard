using LauncherProgram.Interface;
using LauncherProgram.Model;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LauncherProgram.Windows.Manager
{
    public class WindowsHotkeyManager : NativeWindow, IGlobalHotkeyManager
    {
        private const int WM_HOTKEY = 0x0312;
        private const uint MOD_NOREPEAT = 0x4000;

        private int _nextId = 1;
        private bool _disposed;

        private readonly Dictionary<int, HotkeyProgram> _hotkeys = new();

        public event Action<HotkeyProgram>? HotkeyPressed;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(
            IntPtr hWnd,
            int id,
            uint fsModifiers,
            uint vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(
            IntPtr hWnd,
            int id);

        public WindowsHotkeyManager()
        {
            CreateHandle(new CreateParams());
        }

        public bool Register(HotkeyProgram hotkey)
        {
            ObjectDisposedException.ThrowIf(_disposed, this);
            ArgumentNullException.ThrowIfNull(hotkey);

            int id = _nextId++;

            uint modifiers = hotkey.Modifiers | MOD_NOREPEAT;

            bool registered = RegisterHotKey(
                Handle,
                id,
                modifiers,
                hotkey.Key);

            if (!registered)
                return false;

            _hotkeys.Add(id, hotkey);

            return true;
        }

        public bool Unregister(HotkeyProgram hotkey)
        {
            ArgumentNullException.ThrowIfNull(hotkey);

            int id = -1;

            foreach (var item in _hotkeys)
            {
                if (ReferenceEquals(item.Value, hotkey))
                {
                    id = item.Key;
                    break;
                }
            }

            return id != -1 && Unregister(id);
        }

        private bool Unregister(int id)
        {
            if (!_hotkeys.ContainsKey(id))
                return false;

            if (!UnregisterHotKey(Handle, id))
                return false;

            _hotkeys.Remove(id);

            return true;
        }

        public void UnregisterAll()
        {
            foreach (int id in new List<int>(_hotkeys.Keys))
            {
                Unregister(id);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (_hotkeys.TryGetValue(id, out HotkeyProgram? hotkey))
                {
                    HotkeyPressed?.Invoke(hotkey);
                }
            }

            base.WndProc(ref m);
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            UnregisterAll();

            DestroyHandle();

            _disposed = true;
        }
    }
}
