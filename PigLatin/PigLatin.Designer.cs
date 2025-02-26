namespace PigLatin
{
    partial class PigLatin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PigLatin));
            this.lblWordtoConvert = new System.Windows.Forms.Label();
            this.textBoxWordtoConvert = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.lblresults = new System.Windows.Forms.Label();
            this.lblPigLatin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordtoConvert
            // 
            this.lblWordtoConvert.AutoSize = true;
            this.lblWordtoConvert.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordtoConvert.Location = new System.Drawing.Point(35, 144);
            this.lblWordtoConvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWordtoConvert.Name = "lblWordtoConvert";
            this.lblWordtoConvert.Size = new System.Drawing.Size(313, 31);
            this.lblWordtoConvert.TabIndex = 0;
            this.lblWordtoConvert.Text = "Enter A Word to Convert";
            // 
            // textBoxWordtoConvert
            // 
            this.textBoxWordtoConvert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWordtoConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWordtoConvert.Location = new System.Drawing.Point(41, 197);
            this.textBoxWordtoConvert.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWordtoConvert.Name = "textBoxWordtoConvert";
            this.textBoxWordtoConvert.Size = new System.Drawing.Size(298, 38);
            this.textBoxWordtoConvert.TabIndex = 1;
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.Color.Goldenrod;
            this.sumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sumButton.Location = new System.Drawing.Point(86, 269);
            this.sumButton.Margin = new System.Windows.Forms.Padding(2);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(195, 85);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "Click to Convert to Pig Latin";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // lblresults
            // 
            this.lblresults.AutoSize = true;
            this.lblresults.BackColor = System.Drawing.SystemColors.Control;
            this.lblresults.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresults.Location = new System.Drawing.Point(90, 391);
            this.lblresults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresults.Name = "lblresults";
            this.lblresults.Size = new System.Drawing.Size(0, 29);
            this.lblresults.TabIndex = 5;
            this.lblresults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPigLatin
            // 
            this.lblPigLatin.AutoSize = true;
            this.lblPigLatin.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPigLatin.ForeColor = System.Drawing.Color.Black;
            this.lblPigLatin.Location = new System.Drawing.Point(30, 27);
            this.lblPigLatin.Name = "lblPigLatin";
            this.lblPigLatin.Size = new System.Drawing.Size(241, 62);
            this.lblPigLatin.TabIndex = 6;
            this.lblPigLatin.Text = "PigLatin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(476, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 300);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PigLatin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(777, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPigLatin);
            this.Controls.Add(this.lblresults);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.textBoxWordtoConvert);
            this.Controls.Add(this.lblWordtoConvert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PigLatin";
            this.Text = "PigLatin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordtoConvert;
        private System.Windows.Forms.TextBox textBoxWordtoConvert;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label lblresults;
        private System.Windows.Forms.Label lblPigLatin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

