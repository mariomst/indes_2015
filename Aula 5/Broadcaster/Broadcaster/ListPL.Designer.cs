namespace Broadcaster
{
    partial class ListPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPL));
            this.nameLabel = new System.Windows.Forms.Label();
            this.PLname = new System.Windows.Forms.TextBox();
            this.PLBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeLFBtn = new System.Windows.Forms.Button();
            this.addLFBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.removeYTBtn = new System.Windows.Forms.Button();
            this.addYTBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.plList = new System.Windows.Forms.ListView();
            this.lfList = new System.Windows.Forms.ListView();
            this.ytList = new System.Windows.Forms.ListView();
            this.PLBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 22);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Playlist Name:";
            // 
            // PLname
            // 
            this.PLname.Location = new System.Drawing.Point(146, 21);
            this.PLname.Name = "PLname";
            this.PLname.Size = new System.Drawing.Size(605, 20);
            this.PLname.TabIndex = 1;
            // 
            // PLBox
            // 
            this.PLBox.Controls.Add(this.plList);
            this.PLBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLBox.Location = new System.Drawing.Point(446, 66);
            this.PLBox.Name = "PLBox";
            this.PLBox.Size = new System.Drawing.Size(305, 450);
            this.PLBox.TabIndex = 5;
            this.PLBox.TabStop = false;
            this.PLBox.Text = "List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lfList);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Files List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ytList);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 216);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Youtube List";
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::Broadcaster.Properties.Resources.save;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Location = new System.Drawing.Point(714, 531);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(46, 41);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeLFBtn
            // 
            this.removeLFBtn.BackgroundImage = global::Broadcaster.Properties.Resources.left;
            this.removeLFBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeLFBtn.Location = new System.Drawing.Point(346, 203);
            this.removeLFBtn.Name = "removeLFBtn";
            this.removeLFBtn.Size = new System.Drawing.Size(75, 65);
            this.removeLFBtn.TabIndex = 9;
            this.removeLFBtn.UseVisualStyleBackColor = true;
            this.removeLFBtn.Click += new System.EventHandler(this.removeLFBtn_Click);
            // 
            // addLFBtn
            // 
            this.addLFBtn.BackgroundImage = global::Broadcaster.Properties.Resources.right;
            this.addLFBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addLFBtn.Location = new System.Drawing.Point(346, 93);
            this.addLFBtn.Name = "addLFBtn";
            this.addLFBtn.Size = new System.Drawing.Size(75, 65);
            this.addLFBtn.TabIndex = 8;
            this.addLFBtn.UseVisualStyleBackColor = true;
            this.addLFBtn.Click += new System.EventHandler(this.addLFBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::Broadcaster.Properties.Resources.cancel;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.Location = new System.Drawing.Point(778, 531);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(46, 41);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // removeYTBtn
            // 
            this.removeYTBtn.BackgroundImage = global::Broadcaster.Properties.Resources.left;
            this.removeYTBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeYTBtn.Location = new System.Drawing.Point(346, 431);
            this.removeYTBtn.Name = "removeYTBtn";
            this.removeYTBtn.Size = new System.Drawing.Size(75, 65);
            this.removeYTBtn.TabIndex = 12;
            this.removeYTBtn.UseVisualStyleBackColor = true;
            this.removeYTBtn.Click += new System.EventHandler(this.removeYTBtn_Click);
            // 
            // addYTBtn
            // 
            this.addYTBtn.BackgroundImage = global::Broadcaster.Properties.Resources.right;
            this.addYTBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addYTBtn.Location = new System.Drawing.Point(346, 327);
            this.addYTBtn.Name = "addYTBtn";
            this.addYTBtn.Size = new System.Drawing.Size(75, 65);
            this.addYTBtn.TabIndex = 13;
            this.addYTBtn.UseVisualStyleBackColor = true;
            this.addYTBtn.Click += new System.EventHandler(this.addYTBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downBtn.BackgroundImage")));
            this.downBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downBtn.Location = new System.Drawing.Point(769, 337);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(55, 55);
            this.downBtn.TabIndex = 14;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.BackgroundImage = global::Broadcaster.Properties.Resources.up;
            this.upBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upBtn.Location = new System.Drawing.Point(769, 203);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(55, 55);
            this.upBtn.TabIndex = 15;
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // plList
            // 
            this.plList.AutoArrange = false;
            this.plList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plList.LabelWrap = false;
            this.plList.Location = new System.Drawing.Point(7, 27);
            this.plList.Name = "plList";
            this.plList.ShowGroups = false;
            this.plList.Size = new System.Drawing.Size(292, 417);
            this.plList.TabIndex = 0;
            this.plList.UseCompatibleStateImageBehavior = false;
            this.plList.View = System.Windows.Forms.View.Details;
            // 
            // lfList
            // 
            this.lfList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lfList.Location = new System.Drawing.Point(7, 25);
            this.lfList.Name = "lfList";
            this.lfList.Size = new System.Drawing.Size(292, 186);
            this.lfList.TabIndex = 1;
            this.lfList.UseCompatibleStateImageBehavior = false;
            this.lfList.View = System.Windows.Forms.View.List;
            // 
            // ytList
            // 
            this.ytList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ytList.Location = new System.Drawing.Point(6, 25);
            this.ytList.Name = "ytList";
            this.ytList.Size = new System.Drawing.Size(292, 186);
            this.ytList.TabIndex = 2;
            this.ytList.UseCompatibleStateImageBehavior = false;
            this.ytList.View = System.Windows.Forms.View.List;
            // 
            // ListPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 584);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.addYTBtn);
            this.Controls.Add(this.removeYTBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.removeLFBtn);
            this.Controls.Add(this.addLFBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PLBox);
            this.Controls.Add(this.PLname);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListPL";
            this.Text = " Broadcaster: Edit Playlist";
            this.PLBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox PLname;
        private System.Windows.Forms.GroupBox PLBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addLFBtn;
        private System.Windows.Forms.Button removeLFBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button removeYTBtn;
        private System.Windows.Forms.Button addYTBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.ListView plList;
        private System.Windows.Forms.ListView lfList;
        private System.Windows.Forms.ListView ytList;
    }
}