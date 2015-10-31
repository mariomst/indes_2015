namespace Broadcaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalCamera = new System.Windows.Forms.PictureBox();
            this.LC1Btn = new System.Windows.Forms.Button();
            this.WCconfig = new System.Windows.Forms.ComboBox();
            this.LFiles = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.Play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YTFiles = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.axShockwaveFlash2 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.LFList = new System.Windows.Forms.ComboBox();
            this.YTList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btconfig = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LC2Btn = new System.Windows.Forms.Button();
            this.serialPortBT = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.WCaddress = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "INDES - BROADCASTER";
            // 
            // LocalCamera
            // 
            this.LocalCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LocalCamera.Image = global::Broadcaster.Properties.Resources.Static;
            this.LocalCamera.Location = new System.Drawing.Point(29, 137);
            this.LocalCamera.Name = "LocalCamera";
            this.LocalCamera.Size = new System.Drawing.Size(125, 105);
            this.LocalCamera.TabIndex = 2;
            this.LocalCamera.TabStop = false;
            // 
            // LC1Btn
            // 
            this.LC1Btn.BackColor = System.Drawing.Color.Red;
            this.LC1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC1Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC1Btn.Location = new System.Drawing.Point(653, 371);
            this.LC1Btn.Name = "LC1Btn";
            this.LC1Btn.Size = new System.Drawing.Size(75, 51);
            this.LC1Btn.TabIndex = 3;
            this.LC1Btn.Text = "LC1";
            this.LC1Btn.UseVisualStyleBackColor = false;
            this.LC1Btn.Click += new System.EventHandler(this.LC1Btn_Click);
            // 
            // WCconfig
            // 
            this.WCconfig.FormattingEnabled = true;
            this.WCconfig.Location = new System.Drawing.Point(737, 455);
            this.WCconfig.Name = "WCconfig";
            this.WCconfig.Size = new System.Drawing.Size(155, 21);
            this.WCconfig.TabIndex = 4;
            // 
            // LFiles
            // 
            this.LFiles.Enabled = true;
            this.LFiles.Location = new System.Drawing.Point(184, 137);
            this.LFiles.Name = "LFiles";
            this.LFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LFiles.OcxState")));
            this.LFiles.Size = new System.Drawing.Size(125, 105);
            this.LFiles.TabIndex = 5;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(657, 160);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 6;
            this.Play.Text = "button1";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Local Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Youtube";
            // 
            // YTFiles
            // 
            this.YTFiles.Enabled = true;
            this.YTFiles.Location = new System.Drawing.Point(340, 137);
            this.YTFiles.Name = "YTFiles";
            this.YTFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("YTFiles.OcxState")));
            this.YTFiles.Size = new System.Drawing.Size(125, 105);
            this.YTFiles.TabIndex = 10;
            // 
            // axShockwaveFlash2
            // 
            this.axShockwaveFlash2.Enabled = true;
            this.axShockwaveFlash2.Location = new System.Drawing.Point(29, 298);
            this.axShockwaveFlash2.Name = "axShockwaveFlash2";
            this.axShockwaveFlash2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash2.OcxState")));
            this.axShockwaveFlash2.Size = new System.Drawing.Size(255, 215);
            this.axShockwaveFlash2.TabIndex = 11;
            // 
            // LFList
            // 
            this.LFList.FormattingEnabled = true;
            this.LFList.Location = new System.Drawing.Point(184, 259);
            this.LFList.Name = "LFList";
            this.LFList.Size = new System.Drawing.Size(125, 21);
            this.LFList.TabIndex = 12;
            // 
            // YTList
            // 
            this.YTList.FormattingEnabled = true;
            this.YTList.Location = new System.Drawing.Point(340, 259);
            this.YTList.Name = "YTList";
            this.YTList.Size = new System.Drawing.Size(125, 21);
            this.YTList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(653, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "WebCam";
            // 
            // Btconfig
            // 
            this.Btconfig.FormattingEnabled = true;
            this.Btconfig.Location = new System.Drawing.Point(737, 492);
            this.Btconfig.Name = "Btconfig";
            this.Btconfig.Size = new System.Drawing.Size(155, 21);
            this.Btconfig.TabIndex = 15;
            this.Btconfig.SelectedIndexChanged += new System.EventHandler(this.Btconfig_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(610, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bluetooth COM";
            // 
            // LC2Btn
            // 
            this.LC2Btn.BackColor = System.Drawing.Color.Red;
            this.LC2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC2Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC2Btn.Location = new System.Drawing.Point(737, 371);
            this.LC2Btn.Name = "LC2Btn";
            this.LC2Btn.Size = new System.Drawing.Size(75, 51);
            this.LC2Btn.TabIndex = 17;
            this.LC2Btn.Text = "LC2";
            this.LC2Btn.UseVisualStyleBackColor = false;
            this.LC2Btn.Click += new System.EventHandler(this.LC2Btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(634, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "IP WebCam";
            // 
            // WCaddress
            // 
            this.WCaddress.Location = new System.Drawing.Point(737, 529);
            this.WCaddress.Name = "WCaddress";
            this.WCaddress.Size = new System.Drawing.Size(155, 20);
            this.WCaddress.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Broadcaster.Properties.Resources.wallpaper11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 605);
            this.Controls.Add(this.WCaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LC2Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btconfig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YTList);
            this.Controls.Add(this.LFList);
            this.Controls.Add(this.axShockwaveFlash2);
            this.Controls.Add(this.YTFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.LFiles);
            this.Controls.Add(this.WCconfig);
            this.Controls.Add(this.LC1Btn);
            this.Controls.Add(this.LocalCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "INDES - Broadcaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LocalCamera;
        private System.Windows.Forms.Button LC1Btn;
        private System.Windows.Forms.ComboBox WCconfig;
        private AxShockwaveFlashObjects.AxShockwaveFlash LFiles;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AxShockwaveFlashObjects.AxShockwaveFlash YTFiles;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash2;
        private System.Windows.Forms.ComboBox LFList;
        private System.Windows.Forms.ComboBox YTList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Btconfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LC2Btn;
        private System.IO.Ports.SerialPort serialPortBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WCaddress;
    }
}

