using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Dto
{
    public class HotkeyProgramDto
    {
        public string Commands { get; set; } = string.Empty;

        public string Launcher { get; set; } = string.Empty;

        public uint Key { get; set; }

        public uint Modifiers { get; set; }
    }
}
