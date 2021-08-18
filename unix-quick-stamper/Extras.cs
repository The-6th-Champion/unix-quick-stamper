using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace unix_quick_stamper
{
    public class Extras
    {

        public static Color DetermineTheme()
        {
            if (Defaults.color == "Light")
            {
                return Color.FromArgb(0xf2, 0xf2, 0xf2);
            }
            else if (Defaults.color == "Dark")
            {
                return Color.FromArgb(0x17, 0x17, 0x17);
            }
            else
            {
                int key = (int)Registry.GetValue(keyName: @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", valueName: "SystemUsesLightTheme", defaultValue: 1);
                if (key == 0)
                {
                    return Color.FromArgb(0x17, 0x17, 0x17);
                }
                else
                {
                    return Color.FromArgb(0xf2, 0xf2, 0xf2);
                }
            }
        }

        public static Color DetermineFontColor(Color backColor)
        {
            if (backColor == Color.FromArgb(0xf2, 0xf2, 0xf2))
            {
                return Color.FromArgb(0x10, 0x10, 0x10);
            }
            else
            {
                return Color.FromArgb(0xff, 0xff, 0xff);
            }
        }

    }

    public class Options
    {
        public ThemeClass Theme { get; set; }
        public DiscordClass Discord { get; set; }
    }

    public class ThemeClass
    {
        public bool radLight { get; set; }
        public bool radDark { get; set; }
        public bool radWinDef { get; set; }
    }

    public class DiscordClass
    {
        public bool Enabled { get; set; }
        public FormatsClass Formats { get; set; }

    }

    public class FormatsClass
    {
        public bool radt { get; set; }
        public bool radTup { get; set; }
        public bool radd { get; set; }
        public bool radDup { get; set; }
        public bool radf { get; set; }
        public bool radFup { get; set; }
        public bool radR { get; set; }
    }

    public static class Defaults
    {
        public static string color { get; set; }
        public static bool discord { get; set; }
        public static char dformat { get; set; }
    }
}