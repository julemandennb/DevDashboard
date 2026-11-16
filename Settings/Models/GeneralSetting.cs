using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class GeneralSetting : Setting
    {
        public bool StartWithPc { get; set; } = false;

        public bool MinimizedOnStart { get; set; } = false;

        public GeneralSetting() : base("General.json")
        {
        }
    }
}
