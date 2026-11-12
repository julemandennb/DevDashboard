using System;
using System.Collections.Generic;
using System.Text;

namespace DevDashboard.Help
{
    internal static class GetShortcutText
    {
        internal static string Get(uint key, uint modifiers)
        {
            string shortcut = "";

            if ((modifiers & 0x0002) != 0)
                shortcut += "Ctrl + ";

            if ((modifiers & 0x0001) != 0)
                shortcut += "Alt + ";

            if ((modifiers & 0x0004) != 0)
                shortcut += "Shift + ";

            shortcut += ((Keys)key).ToString();

            return shortcut;
        }
    }
}
