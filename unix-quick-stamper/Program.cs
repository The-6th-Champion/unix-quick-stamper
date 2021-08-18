using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace unix_quick_stamper
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static Options OptionsOBJ = JsonConvert.DeserializeObject<Options>(File.ReadAllText("data/options.json"));
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDefaults();
            Application.Run(new Form1());

        }

        static void SetDefaults()
        {
            if (OptionsOBJ.Theme.radLight)
            {
                Defaults.color = "Light";
            }
            else if (OptionsOBJ.Theme.radDark)
            {
                Defaults.color = "Dark";
            }
            else
            {
                Defaults.color = "WinDef";
            }

            if (OptionsOBJ.Discord.Enabled == true)
            {
                Defaults.discord = true;
            }
            else
            {
                Defaults.discord = false;
            }

            if (OptionsOBJ.Discord.Formats.radt)
            {
                Defaults.dformat = 't';
            }
            else if (OptionsOBJ.Discord.Formats.radTup)
            {
                Defaults.dformat = 'T';
            }
            else if (OptionsOBJ.Discord.Formats.radd)
            {
                Defaults.dformat = 'd';
            }
            else if (OptionsOBJ.Discord.Formats.radDup)
            {
                Defaults.dformat = 'D';

            }
            else if (OptionsOBJ.Discord.Formats.radf)
            {
                Defaults.dformat = 'f';

            }
            else if (OptionsOBJ.Discord.Formats.radFup)
            {
                Defaults.dformat = 'F';

            }
            else if (OptionsOBJ.Discord.Formats.radR)
            {
                Defaults.dformat = 'R';

            }
        }
    }
}
