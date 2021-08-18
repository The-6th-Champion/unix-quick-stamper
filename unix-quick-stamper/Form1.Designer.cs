
namespace unix_quick_stamper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetTime = new System.Windows.Forms.Button();
            this.TimeNow = new System.Windows.Forms.Label();
            this.TimeInput = new System.Windows.Forms.TextBox();
            this.FormatsList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetTime
            // 
            this.GetTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetTime.Location = new System.Drawing.Point(485, 27);
            this.GetTime.Name = "GetTime";
            this.GetTime.Size = new System.Drawing.Size(84, 43);
            this.GetTime.TabIndex = 0;
            this.GetTime.Text = "Get Time";
            this.GetTime.UseVisualStyleBackColor = true;
            this.GetTime.Click += new System.EventHandler(this.GetTime_Click);
            // 
            // TimeNow
            // 
            this.TimeNow.AutoSize = true;
            this.TimeNow.Location = new System.Drawing.Point(12, 9);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(208, 15);
            this.TimeNow.TabIndex = 1;
            this.TimeNow.Text = "Type in your time in the proper format";
            // 
            // TimeInput
            // 
            this.TimeInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeInput.Location = new System.Drawing.Point(4, 28);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(475, 43);
            this.TimeInput.TabIndex = 2;
            // 
            // FormatsList
            // 
            this.FormatsList.AutoSize = true;
            this.FormatsList.Location = new System.Drawing.Point(226, 9);
            this.FormatsList.Name = "FormatsList";
            this.FormatsList.Size = new System.Drawing.Size(134, 15);
            this.FormatsList.TabIndex = 3;
            this.FormatsList.Text = "Formats: t, T, d, D, f, F, R";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(565, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 107);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FormatsList);
            this.Controls.Add(this.TimeInput);
            this.Controls.Add(this.TimeNow);
            this.Controls.Add(this.GetTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetTime;
        private System.Windows.Forms.Label TimeNow;
        private System.Windows.Forms.TextBox TimeInput;
        private System.Windows.Forms.Label FormatsList;
        private System.Windows.Forms.Button button1;
    }
}

