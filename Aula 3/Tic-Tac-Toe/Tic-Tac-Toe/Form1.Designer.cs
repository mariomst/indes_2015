namespace Tic_Tac_Toe
{
    partial class formTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelOp = new System.Windows.Forms.Label();
            this.faceBox = new System.Windows.Forms.PictureBox();
            this.boardBox = new System.Windows.Forms.PictureBox();
            this.labelStat = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.box8 = new System.Windows.Forms.PictureBox();
            this.box9 = new System.Windows.Forms.PictureBox();
            this.buttonNG = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp.Location = new System.Drawing.Point(451, 33);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(90, 23);
            this.labelOp.TabIndex = 2;
            this.labelOp.Text = "Opponent";
            // 
            // faceBox
            // 
            this.faceBox.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.face1;
            this.faceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.faceBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.faceBox.Location = new System.Drawing.Point(455, 60);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(201, 202);
            this.faceBox.TabIndex = 3;
            this.faceBox.TabStop = false;
            // 
            // boardBox
            // 
            this.boardBox.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.board;
            this.boardBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boardBox.Location = new System.Drawing.Point(12, 33);
            this.boardBox.Name = "boardBox";
            this.boardBox.Size = new System.Drawing.Size(391, 392);
            this.boardBox.TabIndex = 1;
            this.boardBox.TabStop = false;
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.Location = new System.Drawing.Point(451, 282);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(65, 23);
            this.labelStat.TabIndex = 4;
            this.labelStat.Text = "Status:";
            // 
            // box1
            // 
            this.box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box1.Location = new System.Drawing.Point(28, 50);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(114, 114);
            this.box1.TabIndex = 6;
            this.box1.TabStop = false;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box2
            // 
            this.box2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box2.Location = new System.Drawing.Point(148, 50);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(120, 114);
            this.box2.TabIndex = 7;
            this.box2.TabStop = false;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box3
            // 
            this.box3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box3.Location = new System.Drawing.Point(274, 50);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(111, 114);
            this.box3.TabIndex = 8;
            this.box3.TabStop = false;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box4
            // 
            this.box4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box4.Location = new System.Drawing.Point(28, 170);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(114, 119);
            this.box4.TabIndex = 9;
            this.box4.TabStop = false;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box5
            // 
            this.box5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box5.Location = new System.Drawing.Point(148, 170);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(120, 119);
            this.box5.TabIndex = 10;
            this.box5.TabStop = false;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box6
            // 
            this.box6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box6.Location = new System.Drawing.Point(274, 170);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(111, 119);
            this.box6.TabIndex = 11;
            this.box6.TabStop = false;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box7
            // 
            this.box7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box7.Location = new System.Drawing.Point(28, 295);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(114, 112);
            this.box7.TabIndex = 12;
            this.box7.TabStop = false;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // box8
            // 
            this.box8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box8.Location = new System.Drawing.Point(148, 295);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(120, 112);
            this.box8.TabIndex = 13;
            this.box8.TabStop = false;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box9
            // 
            this.box9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box9.Location = new System.Drawing.Point(274, 295);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(111, 112);
            this.box9.TabIndex = 14;
            this.box9.TabStop = false;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // buttonNG
            // 
            this.buttonNG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNG.Location = new System.Drawing.Point(494, 346);
            this.buttonNG.Name = "buttonNG";
            this.buttonNG.Size = new System.Drawing.Size(128, 29);
            this.buttonNG.TabIndex = 15;
            this.buttonNG.Text = "New Game";
            this.buttonNG.UseVisualStyleBackColor = true;
            this.buttonNG.Click += new System.EventHandler(this.buttonNG_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQ.Location = new System.Drawing.Point(494, 381);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(128, 29);
            this.buttonQ.TabIndex = 16;
            this.buttonQ.Text = "Quit";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // textStatus
            // 
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textStatus.Location = new System.Drawing.Point(455, 309);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(201, 23);
            this.textStatus.TabIndex = 17;
            // 
            // formTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 454);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonNG);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.faceBox);
            this.Controls.Add(this.labelOp);
            this.Controls.Add(this.boardBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.PictureBox boardBox;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.PictureBox faceBox;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox box8;
        private System.Windows.Forms.PictureBox box9;
        private System.Windows.Forms.Button buttonNG;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Label textStatus;
    }
}

