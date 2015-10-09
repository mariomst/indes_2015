namespace Slot_Machine
{
    partial class SlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachine));
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.apostaLabel = new System.Windows.Forms.Label();
            this.saldoValor = new System.Windows.Forms.Label();
            this.apostaBox = new System.Windows.Forms.NumericUpDown();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.apostaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(79, 346);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(240, 23);
            this.result.TabIndex = 4;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saldoLabel
            // 
            this.saldoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saldoLabel.ForeColor = System.Drawing.Color.Black;
            this.saldoLabel.Location = new System.Drawing.Point(22, 386);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(72, 23);
            this.saldoLabel.TabIndex = 5;
            this.saldoLabel.Text = "Saldo: ";
            this.saldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apostaLabel
            // 
            this.apostaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.apostaLabel.ForeColor = System.Drawing.Color.Black;
            this.apostaLabel.Location = new System.Drawing.Point(208, 386);
            this.apostaLabel.Name = "apostaLabel";
            this.apostaLabel.Size = new System.Drawing.Size(67, 23);
            this.apostaLabel.TabIndex = 6;
            this.apostaLabel.Text = "Saldo: ";
            this.apostaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saldoValor
            // 
            this.saldoValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saldoValor.ForeColor = System.Drawing.Color.Black;
            this.saldoValor.Location = new System.Drawing.Point(100, 386);
            this.saldoValor.Name = "saldoValor";
            this.saldoValor.Size = new System.Drawing.Size(90, 23);
            this.saldoValor.TabIndex = 8;
            this.saldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apostaBox
            // 
            this.apostaBox.Location = new System.Drawing.Point(287, 387);
            this.apostaBox.Name = "apostaBox";
            this.apostaBox.Size = new System.Drawing.Size(75, 20);
            this.apostaBox.TabIndex = 9;
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.White;
            this.Box1.BackgroundImage = global::Slot_Machine.Properties.Resources.orange;
            this.Box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box1.Location = new System.Drawing.Point(79, 169);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(69, 78);
            this.Box1.TabIndex = 10;
            this.Box1.TabStop = false;
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.White;
            this.Box2.BackgroundImage = global::Slot_Machine.Properties.Resources.orange;
            this.Box2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box2.Location = new System.Drawing.Point(160, 169);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(69, 78);
            this.Box2.TabIndex = 11;
            this.Box2.TabStop = false;
            // 
            // Box3
            // 
            this.Box3.BackColor = System.Drawing.Color.White;
            this.Box3.BackgroundImage = global::Slot_Machine.Properties.Resources.orange;
            this.Box3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box3.Location = new System.Drawing.Point(239, 169);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(69, 78);
            this.Box3.TabIndex = 12;
            this.Box3.TabStop = false;
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.sairToolStripMenuItem,
            this.exitMenuItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(50, 20);
            this.menuItem.Text = "Menu";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.aboutMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutMenuItem.Text = "S&obre";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(144, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exitMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitMenuItem.Text = "&Sair";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot_Machine.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 480);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.apostaBox);
            this.Controls.Add(this.saldoValor);
            this.Controls.Add(this.apostaLabel);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlotMachine";
            this.Text = "Slot Machine v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.apostaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label apostaLabel;
        private System.Windows.Forms.Label saldoValor;
        private System.Windows.Forms.NumericUpDown apostaBox;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

