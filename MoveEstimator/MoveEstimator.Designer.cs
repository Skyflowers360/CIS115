namespace AddTwoNumbers
{
    partial class MoveEstimator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveEstimator));
            this.lblhours = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.lblmiles = new System.Windows.Forms.Label();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(27, 134);
            this.lblhours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(124, 22);
            this.lblhours.TabIndex = 0;
            this.lblhours.Text = "Enter Hours";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(171, 136);
            this.textBoxHours.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(112, 20);
            this.textBoxHours.TabIndex = 1;
            // 
            // lblmiles
            // 
            this.lblmiles.AutoSize = true;
            this.lblmiles.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiles.Location = new System.Drawing.Point(27, 194);
            this.lblmiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiles.Name = "lblmiles";
            this.lblmiles.Size = new System.Drawing.Size(115, 22);
            this.lblmiles.TabIndex = 2;
            this.lblmiles.Text = "Enter Miles";
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Location = new System.Drawing.Point(171, 194);
            this.textBoxMiles.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.Size = new System.Drawing.Size(112, 20);
            this.textBoxMiles.TabIndex = 3;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(31, 260);
            this.sumButton.Margin = new System.Windows.Forms.Padding(2);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(165, 55);
            this.sumButton.TabIndex = 4;
            this.sumButton.Text = "Click to Estimate Moving Fee";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(29, 351);
            this.results.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 24);
            this.results.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Curious George Moving Estimator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(440, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 218);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MoveEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(705, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.lblmiles);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.lblhours);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoveEstimator";
            this.Text = "MoveEstimator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label lblmiles;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

