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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LFList = new System.Windows.Forms.ComboBox();
            this.YTList = new System.Windows.Forms.ComboBox();
            this.LC2Btn = new System.Windows.Forms.Button();
            this.serialPortBT = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.WCaddress = new System.Windows.Forms.TextBox();
            this.LFiles = new AxWMPLib.AxWindowsMediaPlayer();
            this.Btconfig = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editLF = new System.Windows.Forms.Button();
            this.editYT = new System.Windows.Forms.Button();
            this.lfPicture = new System.Windows.Forms.PictureBox();
            this.ytPicture = new System.Windows.Forms.PictureBox();
            this.YTFiles = new AxWMPLib.AxWindowsMediaPlayer();
            this.livePicture = new System.Windows.Forms.PictureBox();
            this.PLBtn = new System.Windows.Forms.Button();
            this.LA1 = new System.Windows.Forms.Button();
            this.LA2 = new System.Windows.Forms.Button();
            this.LA3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePicture)).BeginInit();
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
            this.LocalCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LocalCamera.Location = new System.Drawing.Point(29, 137);
            this.LocalCamera.Name = "LocalCamera";
            this.LocalCamera.Size = new System.Drawing.Size(125, 105);
            this.LocalCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LocalCamera.TabIndex = 2;
            this.LocalCamera.TabStop = false;
            // 
            // LC1Btn
            // 
            this.LC1Btn.BackColor = System.Drawing.Color.Red;
            this.LC1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC1Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC1Btn.Location = new System.Drawing.Point(531, 333);
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
            this.WCconfig.Location = new System.Drawing.Point(633, 420);
            this.WCconfig.Name = "WCconfig";
            this.WCconfig.Size = new System.Drawing.Size(155, 21);
            this.WCconfig.TabIndex = 4;
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
            // LC2Btn
            // 
            this.LC2Btn.BackColor = System.Drawing.Color.Red;
            this.LC2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC2Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC2Btn.Location = new System.Drawing.Point(623, 333);
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
            this.label7.Location = new System.Drawing.Point(530, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "IP WebCam";
            // 
            // WCaddress
            // 
            this.WCaddress.Location = new System.Drawing.Point(633, 494);
            this.WCaddress.Name = "WCaddress";
            this.WCaddress.Size = new System.Drawing.Size(155, 20);
            this.WCaddress.TabIndex = 19;
            // 
            // LFiles
            // 
            this.LFiles.Enabled = true;
            this.LFiles.Location = new System.Drawing.Point(184, 137);
            this.LFiles.Name = "LFiles";
            this.LFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LFiles.OcxState")));
            this.LFiles.Size = new System.Drawing.Size(125, 105);
            this.LFiles.TabIndex = 22;
            // 
            // Btconfig
            // 
            this.Btconfig.FormattingEnabled = true;
            this.Btconfig.Location = new System.Drawing.Point(633, 457);
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
            this.label6.Location = new System.Drawing.Point(506, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bluetooth COM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(549, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "WebCam";
            // 
            // editLF
            // 
            this.editLF.Location = new System.Drawing.Point(184, 286);
            this.editLF.Name = "editLF";
            this.editLF.Size = new System.Drawing.Size(125, 23);
            this.editLF.TabIndex = 23;
            this.editLF.Text = "Edit List";
            this.editLF.UseVisualStyleBackColor = true;
            this.editLF.Click += new System.EventHandler(this.editLF_Click);
            // 
            // editYT
            // 
            this.editYT.Location = new System.Drawing.Point(340, 286);
            this.editYT.Name = "editYT";
            this.editYT.Size = new System.Drawing.Size(125, 23);
            this.editYT.TabIndex = 24;
            this.editYT.Text = "Edit List";
            this.editYT.UseVisualStyleBackColor = true;
            this.editYT.Click += new System.EventHandler(this.editYT_Click);
            // 
            // lfPicture
            // 
            this.lfPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lfPicture.Location = new System.Drawing.Point(184, 137);
            this.lfPicture.Name = "lfPicture";
            this.lfPicture.Size = new System.Drawing.Size(125, 105);
            this.lfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lfPicture.TabIndex = 25;
            this.lfPicture.TabStop = false;
            // 
            // ytPicture
            // 
            this.ytPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ytPicture.Location = new System.Drawing.Point(340, 137);
            this.ytPicture.Name = "ytPicture";
            this.ytPicture.Size = new System.Drawing.Size(125, 105);
            this.ytPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ytPicture.TabIndex = 26;
            this.ytPicture.TabStop = false;
            // 
            // YTFiles
            // 
            this.YTFiles.Enabled = true;
            this.YTFiles.Location = new System.Drawing.Point(340, 137);
            this.YTFiles.Name = "YTFiles";
            this.YTFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("YTFiles.OcxState")));
            this.YTFiles.Size = new System.Drawing.Size(125, 105);
            this.YTFiles.TabIndex = 27;
            // 
            // livePicture
            // 
            this.livePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.livePicture.Location = new System.Drawing.Point(29, 322);
            this.livePicture.Name = "livePicture";
            this.livePicture.Size = new System.Drawing.Size(255, 215);
            this.livePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livePicture.TabIndex = 28;
            this.livePicture.TabStop = false;
            // 
            // PLBtn
            // 
            this.PLBtn.BackColor = System.Drawing.Color.Red;
            this.PLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLBtn.Location = new System.Drawing.Point(714, 333);
            this.PLBtn.Name = "PLBtn";
            this.PLBtn.Size = new System.Drawing.Size(75, 51);
            this.PLBtn.TabIndex = 29;
            this.PLBtn.Text = "PL";
            this.PLBtn.UseVisualStyleBackColor = false;
            // 
            // LA1
            // 
            this.LA1.BackColor = System.Drawing.Color.Red;
            this.LA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LA1.Location = new System.Drawing.Point(531, 258);
            this.LA1.Name = "LA1";
            this.LA1.Size = new System.Drawing.Size(75, 51);
            this.LA1.TabIndex = 30;
            this.LA1.Text = "1";
            this.LA1.UseVisualStyleBackColor = false;
            this.LA1.Click += new System.EventHandler(this.LA1_Click);
            // 
            // LA2
            // 
            this.LA2.BackColor = System.Drawing.Color.Red;
            this.LA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LA2.Location = new System.Drawing.Point(623, 258);
            this.LA2.Name = "LA2";
            this.LA2.Size = new System.Drawing.Size(75, 51);
            this.LA2.TabIndex = 31;
            this.LA2.Text = "2";
            this.LA2.UseVisualStyleBackColor = false;
            this.LA2.Click += new System.EventHandler(this.LA2_Click);
            // 
            // LA3
            // 
            this.LA3.BackColor = System.Drawing.Color.Red;
            this.LA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LA3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LA3.Location = new System.Drawing.Point(714, 258);
            this.LA3.Name = "LA3";
            this.LA3.Size = new System.Drawing.Size(75, 51);
            this.LA3.TabIndex = 32;
            this.LA3.Text = "3";
            this.LA3.UseVisualStyleBackColor = false;
            this.LA3.Click += new System.EventHandler(this.LA3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Broadcaster.Properties.Resources.wallpaper11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.LA3);
            this.Controls.Add(this.LA2);
            this.Controls.Add(this.LA1);
            this.Controls.Add(this.PLBtn);
            this.Controls.Add(this.livePicture);
            this.Controls.Add(this.lfPicture);
            this.Controls.Add(this.editYT);
            this.Controls.Add(this.editLF);
            this.Controls.Add(this.LFiles);
            this.Controls.Add(this.WCaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LC2Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btconfig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YTList);
            this.Controls.Add(this.LFList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WCconfig);
            this.Controls.Add(this.LC1Btn);
            this.Controls.Add(this.LocalCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ytPicture);
            this.Controls.Add(this.YTFiles);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "INDES - Broadcaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePicture)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LFList;
        private System.Windows.Forms.ComboBox YTList;
        private System.Windows.Forms.Button LC2Btn;
        private System.IO.Ports.SerialPort serialPortBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WCaddress;
        private AxWMPLib.AxWindowsMediaPlayer LFiles;
        private System.Windows.Forms.ComboBox Btconfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editLF;
        private System.Windows.Forms.Button editYT;
        private System.Windows.Forms.PictureBox lfPicture;
        private System.Windows.Forms.PictureBox ytPicture;
        private AxWMPLib.AxWindowsMediaPlayer YTFiles;
        private System.Windows.Forms.PictureBox livePicture;
        private System.Windows.Forms.Button PLBtn;
        private System.Windows.Forms.Button LA1;
        private System.Windows.Forms.Button LA2;
        private System.Windows.Forms.Button LA3;
    }
}

