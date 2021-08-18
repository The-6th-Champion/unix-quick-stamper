
namespace unix_quick_stamper
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ForDiscord = new System.Windows.Forms.CheckBox();
            this.radLight = new System.Windows.Forms.RadioButton();
            this.radWinDef = new System.Windows.Forms.RadioButton();
            this.radDark = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radTup = new System.Windows.Forms.RadioButton();
            this.radf = new System.Windows.Forms.RadioButton();
            this.radt = new System.Windows.Forms.RadioButton();
            this.radd = new System.Windows.Forms.RadioButton();
            this.radDup = new System.Windows.Forms.RadioButton();
            this.radFup = new System.Windows.Forms.RadioButton();
            this.radR = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.colorReload = new System.Windows.Forms.Button();
            this.DFormatPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ColorPanel.SuspendLayout();
            this.DFormatPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForDiscord
            // 
            this.ForDiscord.AutoSize = true;
            this.ForDiscord.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForDiscord.Location = new System.Drawing.Point(263, 66);
            this.ForDiscord.Name = "ForDiscord";
            this.ForDiscord.Size = new System.Drawing.Size(141, 32);
            this.ForDiscord.TabIndex = 1;
            this.ForDiscord.Text = "For Discord?";
            this.ForDiscord.UseVisualStyleBackColor = true;
            this.ForDiscord.CheckedChanged += new System.EventHandler(this.ForDiscord_CheckedChanged);
            // 
            // radLight
            // 
            this.radLight.AutoSize = true;
            this.radLight.Location = new System.Drawing.Point(6, 12);
            this.radLight.Name = "radLight";
            this.radLight.Size = new System.Drawing.Size(86, 19);
            this.radLight.TabIndex = 5;
            this.radLight.TabStop = true;
            this.radLight.Text = "Light Mode";
            this.radLight.UseVisualStyleBackColor = true;
            this.radLight.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // radWinDef
            // 
            this.radWinDef.AutoSize = true;
            this.radWinDef.Location = new System.Drawing.Point(6, 62);
            this.radWinDef.Name = "radWinDef";
            this.radWinDef.Size = new System.Drawing.Size(115, 19);
            this.radWinDef.TabIndex = 6;
            this.radWinDef.TabStop = true;
            this.radWinDef.Text = "Windows Default";
            this.radWinDef.UseVisualStyleBackColor = true;
            this.radWinDef.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // radDark
            // 
            this.radDark.AutoSize = true;
            this.radDark.Location = new System.Drawing.Point(6, 37);
            this.radDark.Name = "radDark";
            this.radDark.Size = new System.Drawing.Size(83, 19);
            this.radDark.TabIndex = 7;
            this.radDark.TabStop = true;
            this.radDark.Text = "Dark Mode";
            this.radDark.UseVisualStyleBackColor = true;
            this.radDark.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Color Theme";
            // 
            // radTup
            // 
            this.radTup.AutoSize = true;
            this.radTup.Location = new System.Drawing.Point(3, 36);
            this.radTup.Name = "radTup";
            this.radTup.Size = new System.Drawing.Size(105, 19);
            this.radTup.TabIndex = 11;
            this.radTup.TabStop = true;
            this.radTup.Text = "T (hh:mm:ss tt)";
            this.radTup.UseVisualStyleBackColor = true;
            this.radTup.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radf
            // 
            this.radf.AutoSize = true;
            this.radf.Location = new System.Drawing.Point(3, 111);
            this.radf.Name = "radf";
            this.radf.Size = new System.Drawing.Size(177, 19);
            this.radf.TabIndex = 10;
            this.radf.TabStop = true;
            this.radf.Text = "f (MMMM d, yyyy hh:mm tt)";
            this.radf.UseVisualStyleBackColor = true;
            this.radf.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radt
            // 
            this.radt.AutoSize = true;
            this.radt.Location = new System.Drawing.Point(3, 11);
            this.radt.Name = "radt";
            this.radt.Size = new System.Drawing.Size(90, 19);
            this.radt.TabIndex = 9;
            this.radt.TabStop = true;
            this.radt.Text = "t (hh:mm tt)";
            this.radt.UseVisualStyleBackColor = true;
            this.radt.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radd
            // 
            this.radd.AutoSize = true;
            this.radd.Location = new System.Drawing.Point(3, 61);
            this.radd.Name = "radd";
            this.radd.Size = new System.Drawing.Size(113, 19);
            this.radd.TabIndex = 14;
            this.radd.TabStop = true;
            this.radd.Text = "d (MM/dd/yyyy)";
            this.radd.UseVisualStyleBackColor = true;
            this.radd.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radDup
            // 
            this.radDup.AutoSize = true;
            this.radDup.Location = new System.Drawing.Point(3, 86);
            this.radDup.Name = "radDup";
            this.radDup.Size = new System.Drawing.Size(128, 19);
            this.radDup.TabIndex = 13;
            this.radDup.TabStop = true;
            this.radDup.Text = "D (MMMM d, yyyy)";
            this.radDup.UseVisualStyleBackColor = true;
            this.radDup.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radFup
            // 
            this.radFup.AutoSize = true;
            this.radFup.Location = new System.Drawing.Point(3, 136);
            this.radFup.Name = "radFup";
            this.radFup.Size = new System.Drawing.Size(213, 19);
            this.radFup.TabIndex = 12;
            this.radFup.TabStop = true;
            this.radFup.Text = "F (dddd, MMMM d, yyyy hh:mm tt)";
            this.radFup.UseVisualStyleBackColor = true;
            this.radFup.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // radR
            // 
            this.radR.AutoSize = true;
            this.radR.Location = new System.Drawing.Point(3, 161);
            this.radR.Name = "radR";
            this.radR.Size = new System.Drawing.Size(84, 19);
            this.radR.TabIndex = 15;
            this.radR.TabStop = true;
            this.radR.Text = "R (Relative)";
            this.radR.UseVisualStyleBackColor = true;
            this.radR.CheckedChanged += new System.EventHandler(this.DFormatChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Default Format:";
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.colorReload);
            this.ColorPanel.Controls.Add(this.radWinDef);
            this.ColorPanel.Controls.Add(this.radDark);
            this.ColorPanel.Controls.Add(this.radLight);
            this.ColorPanel.Location = new System.Drawing.Point(27, 100);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(200, 113);
            this.ColorPanel.TabIndex = 19;
            // 
            // colorReload
            // 
            this.colorReload.Location = new System.Drawing.Point(6, 87);
            this.colorReload.Name = "colorReload";
            this.colorReload.Size = new System.Drawing.Size(179, 23);
            this.colorReload.TabIndex = 8;
            this.colorReload.Text = "Reload for Changes";
            this.colorReload.UseVisualStyleBackColor = true;
            this.colorReload.Click += new System.EventHandler(this.colorReload_Click);
            // 
            // DFormatPanel
            // 
            this.DFormatPanel.Controls.Add(this.radt);
            this.DFormatPanel.Controls.Add(this.radTup);
            this.DFormatPanel.Controls.Add(this.radd);
            this.DFormatPanel.Controls.Add(this.radDup);
            this.DFormatPanel.Controls.Add(this.radR);
            this.DFormatPanel.Controls.Add(this.radf);
            this.DFormatPanel.Controls.Add(this.radFup);
            this.DFormatPanel.Location = new System.Drawing.Point(263, 125);
            this.DFormatPanel.Name = "DFormatPanel";
            this.DFormatPanel.Size = new System.Drawing.Size(218, 185);
            this.DFormatPanel.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(27, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 90);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "repo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Instructions can be found\r\non the repository page";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(31, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "The-6th-Champion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "By ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "This app is not associated with Discord";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DFormatPanel);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ForDiscord);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.DFormatPanel.ResumeLayout(false);
            this.DFormatPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ForDiscord;
        private System.Windows.Forms.RadioButton radLight;
        private System.Windows.Forms.RadioButton radWinDef;
        private System.Windows.Forms.RadioButton radDark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTup;
        private System.Windows.Forms.RadioButton radf;
        private System.Windows.Forms.RadioButton radt;
        private System.Windows.Forms.RadioButton radd;
        private System.Windows.Forms.RadioButton radDup;
        private System.Windows.Forms.RadioButton radFup;
        private System.Windows.Forms.RadioButton radR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel DFormatPanel;
        private System.Windows.Forms.Button colorReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
    }
}