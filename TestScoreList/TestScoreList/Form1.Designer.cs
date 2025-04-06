namespace TestScoreList
{
    partial class Form1
    {
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.TextBox textScore1;
        private System.Windows.Forms.TextBox textScore2;
        private System.Windows.Forms.TextBox textScore3;
        private System.Windows.Forms.TextBox textScore4;
        private System.Windows.Forms.TextBox textScore5;
        private System.Windows.Forms.TextBox textScore6;
        private System.Windows.Forms.TextBox textScore7;
        private System.Windows.Forms.TextBox textScore8;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListBox();
            this.textScore1 = new System.Windows.Forms.TextBox();
            this.textScore2 = new System.Windows.Forms.TextBox();
            this.textScore3 = new System.Windows.Forms.TextBox();
            this.textScore4 = new System.Windows.Forms.TextBox();
            this.textScore5 = new System.Windows.Forms.TextBox();
            this.textScore6 = new System.Windows.Forms.TextBox();
            this.textScore7 = new System.Windows.Forms.TextBox();
            this.textScore8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(99, 408);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(91, 34);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listResults
            // 
            this.listResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 21;
            this.listResults.Location = new System.Drawing.Point(365, 62);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(425, 193);
            this.listResults.TabIndex = 1;
            // 
            // textScore1
            // 
            this.textScore1.Location = new System.Drawing.Point(34, 62);
            this.textScore1.Name = "textScore1";
            this.textScore1.Size = new System.Drawing.Size(100, 20);
            this.textScore1.TabIndex = 2;
            // 
            // textScore2
            // 
            this.textScore2.Location = new System.Drawing.Point(190, 99);
            this.textScore2.Name = "textScore2";
            this.textScore2.Size = new System.Drawing.Size(100, 20);
            this.textScore2.TabIndex = 3;
            // 
            // textScore3
            // 
            this.textScore3.Location = new System.Drawing.Point(34, 136);
            this.textScore3.Name = "textScore3";
            this.textScore3.Size = new System.Drawing.Size(100, 20);
            this.textScore3.TabIndex = 4;
            // 
            // textScore4
            // 
            this.textScore4.Location = new System.Drawing.Point(190, 179);
            this.textScore4.Name = "textScore4";
            this.textScore4.Size = new System.Drawing.Size(100, 20);
            this.textScore4.TabIndex = 5;
            // 
            // textScore5
            // 
            this.textScore5.Location = new System.Drawing.Point(34, 217);
            this.textScore5.Name = "textScore5";
            this.textScore5.Size = new System.Drawing.Size(100, 20);
            this.textScore5.TabIndex = 6;
            // 
            // textScore6
            // 
            this.textScore6.Location = new System.Drawing.Point(190, 259);
            this.textScore6.Name = "textScore6";
            this.textScore6.Size = new System.Drawing.Size(100, 20);
            this.textScore6.TabIndex = 7;
            // 
            // textScore7
            // 
            this.textScore7.Location = new System.Drawing.Point(34, 292);
            this.textScore7.Name = "textScore7";
            this.textScore7.Size = new System.Drawing.Size(100, 20);
            this.textScore7.TabIndex = 8;
            // 
            // textScore8
            // 
            this.textScore8.Location = new System.Drawing.Point(190, 337);
            this.textScore8.Name = "textScore8";
            this.textScore8.Size = new System.Drawing.Size(100, 20);
            this.textScore8.TabIndex = 9;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 624);
            this.Controls.Add(this.textScore8);
            this.Controls.Add(this.textScore7);
            this.Controls.Add(this.textScore6);
            this.Controls.Add(this.textScore5);
            this.Controls.Add(this.textScore4);
            this.Controls.Add(this.textScore3);
            this.Controls.Add(this.textScore2);
            this.Controls.Add(this.textScore1);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "Form1";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
