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
            this.configurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.LocalCamera = new System.Windows.Forms.PictureBox();
            this.LC1Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LFList = new System.Windows.Forms.ComboBox();
            this.YTList = new System.Windows.Forms.ComboBox();
            this.LC2Btn = new System.Windows.Forms.Button();
            this.serialPortBT = new System.IO.Ports.SerialPort(this.components);
            this.editLF = new System.Windows.Forms.Button();
            this.editYT = new System.Windows.Forms.Button();
            this.lfPicture = new System.Windows.Forms.PictureBox();
            this.ytPicture = new System.Windows.Forms.PictureBox();
            this.livePicture = new System.Windows.Forms.PictureBox();
            this.PLBtn = new System.Windows.Forms.Button();
            this.LA1 = new System.Windows.Forms.Button();
            this.LA2 = new System.Windows.Forms.Button();
            this.LA3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LFiles = new AxWMPLib.AxWindowsMediaPlayer();
            this.YTFiles = new AxWMPLib.AxWindowsMediaPlayer();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PLList = new System.Windows.Forms.ListBox();
            this.newPLBtn = new System.Windows.Forms.Button();
            this.editPLBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationMenuItem,
            this.aboutMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // configurationMenuItem
            // 
            this.configurationMenuItem.Name = "configurationMenuItem";
            this.configurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.configurationMenuItem.Size = new System.Drawing.Size(190, 22);
            this.configurationMenuItem.Text = "&Configuration";
            this.configurationMenuItem.Click += new System.EventHandler(this.configurationMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(904, 44);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "INDES - BROADCASTER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocalCamera
            // 
            this.LocalCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LocalCamera.Location = new System.Drawing.Point(30, 123);
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
            this.LC1Btn.Location = new System.Drawing.Point(39, 120);
            this.LC1Btn.Name = "LC1Btn";
            this.LC1Btn.Size = new System.Drawing.Size(75, 51);
            this.LC1Btn.TabIndex = 3;
            this.LC1Btn.Text = "LC1";
            this.LC1Btn.UseVisualStyleBackColor = false;
            this.LC1Btn.Click += new System.EventHandler(this.LC1Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 91);
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
            this.label3.Location = new System.Drawing.Point(203, 90);
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
            this.label4.Location = new System.Drawing.Point(368, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Youtube";
            // 
            // LFList
            // 
            this.LFList.FormattingEnabled = true;
            this.LFList.Location = new System.Drawing.Point(185, 245);
            this.LFList.Name = "LFList";
            this.LFList.Size = new System.Drawing.Size(125, 21);
            this.LFList.TabIndex = 12;
            // 
            // YTList
            // 
            this.YTList.FormattingEnabled = true;
            this.YTList.Location = new System.Drawing.Point(341, 245);
            this.YTList.Name = "YTList";
            this.YTList.Size = new System.Drawing.Size(125, 21);
            this.YTList.TabIndex = 13;
            // 
            // LC2Btn
            // 
            this.LC2Btn.BackColor = System.Drawing.Color.Red;
            this.LC2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC2Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC2Btn.Location = new System.Drawing.Point(131, 120);
            this.LC2Btn.Name = "LC2Btn";
            this.LC2Btn.Size = new System.Drawing.Size(75, 51);
            this.LC2Btn.TabIndex = 17;
            this.LC2Btn.Text = "LC2";
            this.LC2Btn.UseVisualStyleBackColor = false;
            this.LC2Btn.Click += new System.EventHandler(this.LC2Btn_Click);
            // 
            // editLF
            // 
            this.editLF.Location = new System.Drawing.Point(185, 272);
            this.editLF.Name = "editLF";
            this.editLF.Size = new System.Drawing.Size(125, 23);
            this.editLF.TabIndex = 23;
            this.editLF.Text = "Edit List";
            this.editLF.UseVisualStyleBackColor = true;
            this.editLF.Click += new System.EventHandler(this.editLF_Click);
            // 
            // editYT
            // 
            this.editYT.Location = new System.Drawing.Point(341, 272);
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
            this.lfPicture.Location = new System.Drawing.Point(185, 123);
            this.lfPicture.Name = "lfPicture";
            this.lfPicture.Size = new System.Drawing.Size(125, 105);
            this.lfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lfPicture.TabIndex = 25;
            this.lfPicture.TabStop = false;
            // 
            // ytPicture
            // 
            this.ytPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ytPicture.Location = new System.Drawing.Point(341, 123);
            this.ytPicture.Name = "ytPicture";
            this.ytPicture.Size = new System.Drawing.Size(125, 105);
            this.ytPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ytPicture.TabIndex = 26;
            this.ytPicture.TabStop = false;
            // 
            // livePicture
            // 
            this.livePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.livePicture.Location = new System.Drawing.Point(105, 313);
            this.livePicture.Name = "livePicture";
            this.livePicture.Size = new System.Drawing.Size(335, 215);
            this.livePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livePicture.TabIndex = 28;
            this.livePicture.TabStop = false;
            // 
            // PLBtn
            // 
            this.PLBtn.BackColor = System.Drawing.Color.Red;
            this.PLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLBtn.Location = new System.Drawing.Point(222, 120);
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
            this.LA1.Location = new System.Drawing.Point(39, 45);
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
            this.LA2.Location = new System.Drawing.Point(131, 45);
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
            this.LA3.Location = new System.Drawing.Point(222, 45);
            this.LA3.Name = "LA3";
            this.LA3.Size = new System.Drawing.Size(75, 51);
            this.LA3.TabIndex = 32;
            this.LA3.Text = "3";
            this.LA3.UseVisualStyleBackColor = false;
            this.LA3.Click += new System.EventHandler(this.LA3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PLBtn);
            this.groupBox1.Controls.Add(this.LA3);
            this.groupBox1.Controls.Add(this.LC1Btn);
            this.groupBox1.Controls.Add(this.LA2);
            this.groupBox1.Controls.Add(this.LC2Btn);
            this.groupBox1.Controls.Add(this.LA1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(511, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 200);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // LFiles
            // 
            this.LFiles.Enabled = true;
            this.LFiles.Location = new System.Drawing.Point(185, 123);
            this.LFiles.Name = "LFiles";
            this.LFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LFiles.OcxState")));
            this.LFiles.Size = new System.Drawing.Size(125, 105);
            this.LFiles.TabIndex = 22;
            // 
            // YTFiles
            // 
            this.YTFiles.Enabled = true;
            this.YTFiles.Location = new System.Drawing.Point(341, 123);
            this.YTFiles.Name = "YTFiles";
            this.YTFiles.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("YTFiles.OcxState")));
            this.YTFiles.Size = new System.Drawing.Size(125, 105);
            this.YTFiles.TabIndex = 27;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Location = new System.Drawing.Point(12, 458);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(70, 70);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 34;
            this.logoBox.TabStop = false;
            // 
            // categoryList
            // 
            this.categoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(6, 28);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(262, 21);
            this.categoryList.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.editPLBtn);
            this.groupBox2.Controls.Add(this.newPLBtn);
            this.groupBox2.Controls.Add(this.PLList);
            this.groupBox2.Controls.Add(this.categoryList);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(470, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 215);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist";
            // 
            // PLList
            // 
            this.PLList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PLList.FormattingEnabled = true;
            this.PLList.Location = new System.Drawing.Point(7, 56);
            this.PLList.Name = "PLList";
            this.PLList.Size = new System.Drawing.Size(261, 134);
            this.PLList.TabIndex = 36;
            // 
            // newPLBtn
            // 
            this.newPLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.newPLBtn.ForeColor = System.Drawing.Color.Black;
            this.newPLBtn.Location = new System.Drawing.Point(281, 42);
            this.newPLBtn.Name = "newPLBtn";
            this.newPLBtn.Size = new System.Drawing.Size(75, 51);
            this.newPLBtn.TabIndex = 37;
            this.newPLBtn.Text = "New Playlist";
            this.newPLBtn.UseVisualStyleBackColor = true;
            this.newPLBtn.Click += new System.EventHandler(this.newPLBtn_Click);
            // 
            // editPLBtn
            // 
            this.editPLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editPLBtn.ForeColor = System.Drawing.Color.Black;
            this.editPLBtn.Location = new System.Drawing.Point(281, 125);
            this.editPLBtn.Name = "editPLBtn";
            this.editPLBtn.Size = new System.Drawing.Size(75, 51);
            this.editPLBtn.TabIndex = 38;
            this.editPLBtn.Text = "Edit Playlist";
            this.editPLBtn.UseVisualStyleBackColor = true;
            this.editPLBtn.Click += new System.EventHandler(this.editPLBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Broadcaster.Properties.Resources.wallpaper11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 554);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.livePicture);
            this.Controls.Add(this.lfPicture);
            this.Controls.Add(this.editYT);
            this.Controls.Add(this.editLF);
            this.Controls.Add(this.LFiles);
            this.Controls.Add(this.YTList);
            this.Controls.Add(this.LFList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalCamera);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ytPicture);
            this.Controls.Add(this.YTFiles);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INDES - Broadcaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox LocalCamera;
        private System.Windows.Forms.Button LC1Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LFList;
        private System.Windows.Forms.ComboBox YTList;
        private System.Windows.Forms.Button LC2Btn;
        private System.IO.Ports.SerialPort serialPortBT;
        private AxWMPLib.AxWindowsMediaPlayer LFiles;
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
        private System.Windows.Forms.ToolStripMenuItem configurationMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox PLList;
        private System.Windows.Forms.Button editPLBtn;
        private System.Windows.Forms.Button newPLBtn;
    }
}

