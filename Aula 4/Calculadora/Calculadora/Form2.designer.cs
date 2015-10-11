namespace Calculadora
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelAuthor1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(12, 21);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(464, 32);
            this.labelTexto.TabIndex = 1;
            this.labelTexto.Text = "Aplicação desenvolvida pelos alunos:";
            // 
            // labelAuthor1
            // 
            this.labelAuthor1.AutoSize = true;
            this.labelAuthor1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor1.Location = new System.Drawing.Point(90, 74);
            this.labelAuthor1.Name = "labelAuthor1";
            this.labelAuthor1.Size = new System.Drawing.Size(319, 22);
            this.labelAuthor1.TabIndex = 2;
            this.labelAuthor1.Text = "Mário Teixeira - 1090626@isep.ipp.pt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hugo Santos - 1091330@isep.ipp.pt";
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = global::Calculadora.Properties.Resources.logo;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Location = new System.Drawing.Point(330, 166);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(164, 158);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAuthor1);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAbout";
            this.Text = "Calculadora: Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelAuthor1;
        private System.Windows.Forms.Label label1;
    }
}