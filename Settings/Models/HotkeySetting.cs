using Settings.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class HotkeySetting : Setting
    {
        public List<HotkeyProgramDto> Hotkeys { get; set; } = new();

        public HotkeySetting() : base("Hotkeys.json")
        {
        }
    }
}
