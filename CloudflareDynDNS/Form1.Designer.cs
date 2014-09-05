namespace CloudflareDynDNS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.APIKEY = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CloudFlareStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TimeoutBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StartUpBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label4.Location = new System.Drawing.Point(95, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "(Per Minute)";
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(53, 77);
            this.Delay.MaxLength = 6;
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(38, 20);
            this.Delay.TabIndex = 12;
            this.Delay.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Delay";
            // 
            // DNS
            // 
            this.DNS.Location = new System.Drawing.Point(165, 53);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(170, 20);
            this.DNS.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "API key ";
            this.label1.Visible = false;
            // 
            // APIKEY
            // 
            this.APIKEY.Location = new System.Drawing.Point(53, 3);
            this.APIKEY.MaxLength = 37;
            this.APIKEY.Name = "APIKEY";
            this.APIKEY.Size = new System.Drawing.Size(282, 20);
            this.APIKEY.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(197, 126);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(138, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(53, 28);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(282, 20);
            this.Email.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 152);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(337, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(4, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "API key ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CloudFlareStatus
            // 
            this.CloudFlareStatus.FormattingEnabled = true;
            this.CloudFlareStatus.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.CloudFlareStatus.Location = new System.Drawing.Point(287, 76);
            this.CloudFlareStatus.Name = "CloudFlareStatus";
            this.CloudFlareStatus.Size = new System.Drawing.Size(48, 21);
            this.CloudFlareStatus.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(196, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CloudFlare Mode";
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(54, 53);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(96, 20);
            this.Sub.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Timeout";
            // 
            // TimeoutBox
            // 
            this.TimeoutBox.Location = new System.Drawing.Point(53, 101);
            this.TimeoutBox.Name = "TimeoutBox";
            this.TimeoutBox.Size = new System.Drawing.Size(38, 20);
            this.TimeoutBox.TabIndex = 25;
            this.TimeoutBox.Text = "15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label9.Location = new System.Drawing.Point(95, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "(Per Second)";
            // 
            // StartUpBox
            // 
            this.StartUpBox.AutoSize = true;
            this.StartUpBox.Location = new System.Drawing.Point(200, 104);
            this.StartUpBox.Name = "StartUpBox";
            this.StartUpBox.Size = new System.Drawing.Size(91, 17);
            this.StartUpBox.TabIndex = 27;
            this.StartUpBox.Text = "Run@Startup";
            this.StartUpBox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "im gonna stay here";
            this.notifyIcon1.BalloonTipTitle = "Just 2 let u know";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 174);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StartUpBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TimeoutBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloudFlareStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DNS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIKEY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CloudflareDynDNS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DNS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox APIKEY;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ComboBox CloudFlareStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TimeoutBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox StartUpBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;


    }
}

