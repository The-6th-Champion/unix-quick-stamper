using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace unix_quick_stamper
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );



        public Form1()
        {
            Color bgColor = Extras.DetermineTheme();
            Color fgColor = Extras.DetermineFontColor(bgColor);

            InitializeComponent();
            this.BackColor = bgColor;
            this.Shown += Form1_Shown;
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

            GetTime.BackColor = fgColor;
            GetTime.ForeColor = bgColor;
            GetTime.FlatStyle = FlatStyle.Flat;
            GetTime.FlatAppearance.BorderSize = 0;
            GetTime.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, GetTime.Width, GetTime.Height, 5, 5));
            
            button1.BackColor = fgColor;
            button1.ForeColor = bgColor;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));

            TimeInput.BorderStyle = BorderStyle.None;
            TimeInput.KeyDown += TimeInput_KeyDown;
            TimeInput.ForeColor = fgColor;
            TimeInput.BackColor = bgColor;
            TimeNow.ForeColor = fgColor;
            FormatsList.ForeColor = fgColor;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TimeInput.Select();
        }

        private void GetTime_Click(object sender, EventArgs e)
        {
            string rawSmartIn = TimeInput.Text;
            string smartIn = "";
            char pasteFormat = rawSmartIn[rawSmartIn.Length - 1];
            char[] discordTsFormats = { 't', 'T', 'd', 'D', 'f', 'F', 'R' };
            bool legalFormat = false;
            foreach (char dTsF in discordTsFormats)
            {
                if (pasteFormat == dTsF)
                {
                    legalFormat = true;
                    break;
                }
            }
            if (!legalFormat)
            {
                pasteFormat = Defaults.dformat;
                smartIn = rawSmartIn;
            }
            else
            {
                if (rawSmartIn == string.Empty || rawSmartIn == "")
                {
                    smartIn = "";
                }
                else
                {
                    for (int i = 0; i < rawSmartIn.Length - 1; i++)
                    {
                        smartIn += rawSmartIn[i];

                    }
                }
            }
            string[] formats = { "HH:mm", "HH:mm:ss", "HH:mmZ", "HH:mm:ssZ", "yyyy-MM-dd", "yyyy-MM-ddTHH:mm", "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-ddTHH:mmTZD", "yyyy-MM-ddTHH:mm:ssTZD", "dddd" };
            if (smartIn == "" || smartIn == "now")
            {
                if (Defaults.discord)
                {
                    Clipboard.SetText($"<t:{((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds()}:{pasteFormat}>");
                }
                else if (!Defaults.discord)
                {
                    Clipboard.SetText($"{((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds()}");
                }
                Application.Exit();
            }
            else
            {
                try
                {
                    DateTime thing = DateTime.ParseExact(smartIn, formats: formats, System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    if (Defaults.discord)
                    {
                        Clipboard.SetText($"<t:{((DateTimeOffset)thing).ToUnixTimeSeconds()}:{pasteFormat}>");
                    }
                    else if (!Defaults.discord)
                    {
                        Clipboard.SetText($"{((DateTimeOffset)thing).ToUnixTimeSeconds()}");
                    }
                    Application.Exit();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    Application.Restart();
                }
            }
        }

        private void TimeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTime.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 optionsForm = new Form2();

            optionsForm.Show();
        }
    }
}
