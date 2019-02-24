namespace KSJiPP5
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
            this.userControl11 = new KSJiPP5.UserControl1();
            this.buttonMotor = new System.Windows.Forms.Button();
            this.textBoxSamochod = new System.Windows.Forms.TextBox();
            this.buttonSamochod = new System.Windows.Forms.Button();
            this.textBoxMotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userControl11.ForeColor = System.Drawing.Color.Red;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(256, 37);
            this.userControl11.TabIndex = 1;
            this.userControl11.Text = "Wcisnąć w razie potrzeby";
            this.userControl11.UseVisualStyleBackColor = true;
            // 
            // buttonMotor
            // 
            this.buttonMotor.Location = new System.Drawing.Point(395, 70);
            this.buttonMotor.Name = "buttonMotor";
            this.buttonMotor.Size = new System.Drawing.Size(141, 23);
            this.buttonMotor.TabIndex = 2;
            this.buttonMotor.Text = "Przyspiesz motorem o";
            this.buttonMotor.UseVisualStyleBackColor = true;
            this.buttonMotor.Click += new System.EventHandler(this.buttonMotor_Click);
            // 
            // textBoxSamochod
            // 
            this.textBoxSamochod.Location = new System.Drawing.Point(549, 142);
            this.textBoxSamochod.Name = "textBoxSamochod";
            this.textBoxSamochod.Size = new System.Drawing.Size(100, 20);
            this.textBoxSamochod.TabIndex = 4;
            // 
            // buttonSamochod
            // 
            this.buttonSamochod.Location = new System.Drawing.Point(395, 140);
            this.buttonSamochod.Name = "buttonSamochod";
            this.buttonSamochod.Size = new System.Drawing.Size(141, 23);
            this.buttonSamochod.TabIndex = 5;
            this.buttonSamochod.Text = "Przyspiesz samochodem o";
            this.buttonSamochod.UseVisualStyleBackColor = true;
            this.buttonSamochod.Click += new System.EventHandler(this.buttonSamochod_Click);
            // 
            // textBoxMotor
            // 
            this.textBoxMotor.Location = new System.Drawing.Point(549, 72);
            this.textBoxMotor.Name = "textBoxMotor";
            this.textBoxMotor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMotor);
            this.Controls.Add(this.buttonSamochod);
            this.Controls.Add(this.textBoxSamochod);
            this.Controls.Add(this.buttonMotor);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button buttonMotor;
        private System.Windows.Forms.TextBox textBoxSamochod;
        private System.Windows.Forms.Button buttonSamochod;
        private System.Windows.Forms.TextBox textBoxMotor;
    }
}

