namespace JNJiPP5
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
            this.textBoxTramwaj = new System.Windows.Forms.TextBox();
            this.textBoxAutobus = new System.Windows.Forms.TextBox();
            this.tramwajButton = new JNJiPP5.UserControl1();
            this.autobusButton = new JNJiPP5.UserControl1();
            this.SuspendLayout();
            // 
            // textBoxTramwaj
            // 
            this.textBoxTramwaj.Location = new System.Drawing.Point(319, 153);
            this.textBoxTramwaj.Name = "textBoxTramwaj";
            this.textBoxTramwaj.Size = new System.Drawing.Size(149, 20);
            this.textBoxTramwaj.TabIndex = 4;
            // 
            // textBoxAutobus
            // 
            this.textBoxAutobus.Location = new System.Drawing.Point(319, 77);
            this.textBoxAutobus.Name = "textBoxAutobus";
            this.textBoxAutobus.Size = new System.Drawing.Size(149, 20);
            this.textBoxAutobus.TabIndex = 6;
            // 
            // tramwajButton
            // 
            this.tramwajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tramwajButton.ForeColor = System.Drawing.Color.Black;
            this.tramwajButton.Location = new System.Drawing.Point(69, 140);
            this.tramwajButton.Name = "tramwajButton";
            this.tramwajButton.Size = new System.Drawing.Size(244, 33);
            this.tramwajButton.TabIndex = 7;
            this.tramwajButton.Text = "Zmien predkosc tramwaju";
            this.tramwajButton.UseVisualStyleBackColor = true;
            this.tramwajButton.Click += new System.EventHandler(this.tramwajButton_Click);
            // 
            // autobusButton
            // 
            this.autobusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.autobusButton.ForeColor = System.Drawing.Color.Black;
            this.autobusButton.Location = new System.Drawing.Point(57, 66);
            this.autobusButton.Name = "autobusButton";
            this.autobusButton.Size = new System.Drawing.Size(256, 31);
            this.autobusButton.TabIndex = 1;
            this.autobusButton.Text = "Zmien predkosc autobusu";
            this.autobusButton.UseVisualStyleBackColor = true;
            this.autobusButton.Click += new System.EventHandler(this.autobusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tramwajButton);
            this.Controls.Add(this.textBoxAutobus);
            this.Controls.Add(this.textBoxTramwaj);
            this.Controls.Add(this.autobusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 autobusButton;
        private System.Windows.Forms.TextBox textBoxTramwaj;
        private System.Windows.Forms.TextBox textBoxAutobus;
        private UserControl1 tramwajButton;
    }
}

