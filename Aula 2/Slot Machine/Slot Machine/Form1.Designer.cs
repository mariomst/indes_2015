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
            this.button1 = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.Label();
            this.Box3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.apostaLabel = new System.Windows.Forms.Label();
            this.saldoValor = new System.Windows.Forms.Label();
            this.apostaBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.apostaBox)).BeginInit();
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
            // Box1
            // 
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(79, 167);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(67, 83);
            this.Box1.TabIndex = 1;
            this.Box1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box2
            // 
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.Location = new System.Drawing.Point(161, 167);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(67, 83);
            this.Box2.TabIndex = 2;
            this.Box2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box3
            // 
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box3.Font = new System.Drawing.Font("Microsoft Sans Serif", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box3.Location = new System.Drawing.Point(240, 167);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(67, 83);
            this.Box3.TabIndex = 3;
            this.Box3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // SlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot_Machine.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 480);
            this.Controls.Add(this.apostaBox);
            this.Controls.Add(this.saldoValor);
            this.Controls.Add(this.apostaLabel);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.button1);
            this.Name = "SlotMachine";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.apostaBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Box1;
        private System.Windows.Forms.Label Box2;
        private System.Windows.Forms.Label Box3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label saldoLabel;
        private System.Windows.Forms.Label apostaLabel;
        private System.Windows.Forms.Label saldoValor;
        private System.Windows.Forms.NumericUpDown apostaBox;
    }
}

