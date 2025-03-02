namespace Twitter
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing"
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
            txtMessage = new TextBox();
            buttonSubmit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessage.Location = new Point(36, 142);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(729, 56);
            txtMessage.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Castellar", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(280, 225);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(225, 56);
            buttonSubmit.TabIndex = 1;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Castellar", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 47);
            label1.Name = "label1";
            label1.Size = new Size(319, 29);
            label1.TabIndex = 2;
            label1.Text = "Enter your Message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 540);
            Controls.Add(label1);
            Controls.Add(buttonSubmit);
            Controls.Add(txtMessage);
            Name = "Form1";
            Text = "Twitter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMessage;
        private Button buttonSubmit;
        private Label label1;
    }
}
