using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class AppearanceSetting : Setting
    {
        public bool DarkModel { get; set; } = true;

        public AppearanceSetting() : base("Appearance.json")
        {
        }
    }
}
