namespace Hurricane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textWindSpeed = new TextBox();
            buttonClassify = new Button();
            labelCategory = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textWindSpeed
            // 
            textWindSpeed.BackColor = Color.FromArgb(192, 255, 255);
            textWindSpeed.Font = new Font("Mongolian Baiti", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textWindSpeed.Location = new Point(367, 78);
            textWindSpeed.Name = "textWindSpeed";
            textWindSpeed.Size = new Size(100, 39);
            textWindSpeed.TabIndex = 0;
            // 
            // buttonClassify
            // 
            buttonClassify.BackColor = Color.FromArgb(192, 255, 255);
            buttonClassify.Font = new Font("Mongolian Baiti", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClassify.Location = new Point(86, 168);
            buttonClassify.Name = "buttonClassify";
            buttonClassify.Size = new Size(143, 46);
            buttonClassify.TabIndex = 1;
            buttonClassify.Text = "Classify";
            buttonClassify.UseVisualStyleBackColor = false;
            buttonClassify.Click += buttonClassify_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.FromArgb(192, 255, 255);
            labelCategory.Font = new Font("Mongolian Baiti", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(86, 275);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(430, 34);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category will be displayed here:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Mongolian Baiti", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 78);
            label1.Name = "label1";
            label1.Size = new Size(259, 34);
            label1.TabIndex = 3;
            label1.Text = "Enter Wind Speed:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(851, 561);
            Controls.Add(label1);
            Controls.Add(labelCategory);
            Controls.Add(buttonClassify);
            Controls.Add(textWindSpeed);
            Name = "Form1";
            Text = "Hurricane";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textWindSpeed;
        private Button buttonClassify;
        private Label labelCategory;
        private Label label1;
    }
}
