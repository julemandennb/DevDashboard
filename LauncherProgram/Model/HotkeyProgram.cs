using LauncherProgram.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LauncherProgram.Model
{
    public class HotkeyProgram(string commands, LauncherSystem launcher, uint key, uint modifiers)
    {
        public string Commands { get; init; } = commands;

        public LauncherSystem Launcher { get; init; } = launcher;

        public uint Key { get; init; } = key;

        public uint Modifiers { get; init; } = modifiers;
    }
}
