using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static unix_quick_stamper.Program;

namespace unix_quick_stamper
{
    public partial class Form2 : Form
    {

        public string defaultFormat;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radLight.Checked = OptionsOBJ.Theme.radLight;
            radDark.Checked = OptionsOBJ.Theme.radDark;
            radWinDef.Checked = OptionsOBJ.Theme.radWinDef;

            ForDiscord.Checked = OptionsOBJ.Discord.Enabled;
            
            radt.Checked = OptionsOBJ.Discord.Formats.radt;
            radTup.Checked = OptionsOBJ.Discord.Formats.radTup;
            radd.Checked = OptionsOBJ.Discord.Formats.radd;
            radDup.Checked = OptionsOBJ.Discord.Formats.radDup;
            radf.Checked = OptionsOBJ.Discord.Formats.radf;
            radFup.Checked = OptionsOBJ.Discord.Formats.radFup;
            radR.Checked = OptionsOBJ.Discord.Formats.radR;
            
            colorReload.Enabled = false;


        }

        private void ForDiscord_CheckedChanged(object sender, EventArgs e)
        {
            if (ForDiscord.Checked == false)
            {
                radt.Enabled = false;
                radTup.Enabled = false;
                radd.Enabled = false;
                radDup.Enabled = false;
                radf.Enabled = false;
                radFup.Enabled = false;
                radR.Enabled = false;
                OptionsOBJ.Discord.Enabled = false;
                Defaults.discord = false;
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));
            }
            else if (ForDiscord.Checked == true)
            {
                radt.Enabled = true;
                radTup.Enabled = true;
                radd.Enabled = true;
                radDup.Enabled = true;
                radf.Enabled = true;
                radFup.Enabled = true;
                radR.Enabled = true;
                OptionsOBJ.Discord.Enabled = true;
                Defaults.discord = true;
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));
            }
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (radLight.Checked)
            {
                colorReload.Enabled = true;
                OptionsOBJ.Theme.radLight = true;
                OptionsOBJ.Theme.radDark = false;
                OptionsOBJ.Theme.radWinDef = false;
                Defaults.color = "Light";
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radDark.Checked)
            {
                colorReload.Enabled = true;
                OptionsOBJ.Theme.radLight = false;
                OptionsOBJ.Theme.radDark = true;
                OptionsOBJ.Theme.radWinDef = false;
                Defaults.color = "Dark";
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radWinDef.Checked)
            {
                colorReload.Enabled = true;
                OptionsOBJ.Theme.radLight = false;
                OptionsOBJ.Theme.radDark = false;
                OptionsOBJ.Theme.radWinDef = true;
                Defaults.color = "WinDef";
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
        }

        private void DFormatChange(object sender, EventArgs e)
        {
            if (radt.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = true;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 't';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radTup.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = true;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 'T';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radd.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = true;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 'd';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radDup.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = true;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 'D';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radf.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = true;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 'f';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radFup.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = true;
                OptionsOBJ.Discord.Formats.radR = false;
                Defaults.dformat = 'F';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
            else if (radR.Checked)
            {
                OptionsOBJ.Discord.Formats.radt = false;
                OptionsOBJ.Discord.Formats.radTup = false;
                OptionsOBJ.Discord.Formats.radd = false;
                OptionsOBJ.Discord.Formats.radDup = false;
                OptionsOBJ.Discord.Formats.radf = false;
                OptionsOBJ.Discord.Formats.radFup = false;
                OptionsOBJ.Discord.Formats.radR = true;
                Defaults.dformat = 'R';
                File.WriteAllText("data/options.json", JsonConvert.SerializeObject(OptionsOBJ));

            }
        }

        private void colorReload_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/The-6th-Champion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/The-6th-Champion/unix-quick-stamper");
        }
    }
}
