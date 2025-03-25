namespace MultiplicationTable
{
    partial class MultiplicationTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplicationTable));
            label1 = new Label();
            textBox1 = new TextBox();
            btnGenerate = new Button();
            listBoxresults = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 89);
            label1.Name = "label1";
            label1.Size = new Size(186, 27);
            label1.TabIndex = 0;
            label1.Text = "Enter an integer:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(150, 234);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(161, 41);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Table";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // listBoxresults
            // 
            listBoxresults.BackColor = SystemColors.InactiveCaption;
            listBoxresults.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxresults.FormattingEnabled = true;
            listBoxresults.ItemHeight = 24;
            listBoxresults.Location = new Point(483, 75);
            listBoxresults.Name = "listBoxresults";
            listBoxresults.Size = new Size(236, 316);
            listBoxresults.TabIndex = 3;
            // 
            // MultiplicationTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxresults);
            Controls.Add(btnGenerate);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MultiplicationTable";
            Text = "Multiplication Table";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnGenerate;
        private ListBox listBoxresults;
    }
}
