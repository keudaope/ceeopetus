namespace WindowsFormsApp1
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
            this.UusiTiliButton = new System.Windows.Forms.Button();
            this.MitaLabel = new System.Windows.Forms.Label();
            this.TalletusButton = new System.Windows.Forms.Button();
            this.NostoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UusiTiliButton
            // 
            this.UusiTiliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiTiliButton.Location = new System.Drawing.Point(130, 98);
            this.UusiTiliButton.Name = "UusiTiliButton";
            this.UusiTiliButton.Size = new System.Drawing.Size(294, 79);
            this.UusiTiliButton.TabIndex = 0;
            this.UusiTiliButton.Text = "Luoda uuden tilin";
            this.UusiTiliButton.UseVisualStyleBackColor = true;
            this.UusiTiliButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MitaLabel
            // 
            this.MitaLabel.AutoSize = true;
            this.MitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MitaLabel.Location = new System.Drawing.Point(68, 25);
            this.MitaLabel.Name = "MitaLabel";
            this.MitaLabel.Size = new System.Drawing.Size(419, 55);
            this.MitaLabel.TabIndex = 1;
            this.MitaLabel.Text = "Mitä haluat tehdä?";
            // 
            // TalletusButton
            // 
            this.TalletusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalletusButton.Location = new System.Drawing.Point(130, 212);
            this.TalletusButton.Name = "TalletusButton";
            this.TalletusButton.Size = new System.Drawing.Size(294, 79);
            this.TalletusButton.TabIndex = 2;
            this.TalletusButton.Text = "Tallettaa tilille";
            this.TalletusButton.UseVisualStyleBackColor = true;
            // 
            // NostoButton
            // 
            this.NostoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NostoButton.Location = new System.Drawing.Point(130, 327);
            this.NostoButton.Name = "NostoButton";
            this.NostoButton.Size = new System.Drawing.Size(294, 79);
            this.NostoButton.TabIndex = 3;
            this.NostoButton.Text = "Nostaa rahaa";
            this.NostoButton.UseVisualStyleBackColor = true;
            this.NostoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(569, 458);
            this.Controls.Add(this.NostoButton);
            this.Controls.Add(this.TalletusButton);
            this.Controls.Add(this.MitaLabel);
            this.Controls.Add(this.UusiTiliButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UusiTiliButton;
        private System.Windows.Forms.Label MitaLabel;
        private System.Windows.Forms.Button TalletusButton;
        private System.Windows.Forms.Button NostoButton;
    }
}

