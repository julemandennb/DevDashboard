using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class TimesSetting : Setting
    {

        public string PomodoroSoundName { get; set; } = string.Empty;

        public string AlarmSoundName { get; set; } = string.Empty;

        public TimesSetting() : base("Times.json")
        {
        }
    }
}
