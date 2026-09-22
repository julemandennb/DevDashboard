using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class ClipboardSetting : Setting
    {
        public bool Ison { get; set; } = false;

        public int Max { get; set; } = 15;
        public ClipboardSetting() : base("Clipboard.json")
        {
        }
    }
}
