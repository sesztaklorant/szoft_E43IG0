namespace Labirintus
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
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(314, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1846, 1334);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(27, 197);
            button1.Name = "button1";
            button1.Size = new Size(250, 100);
            button1.TabIndex = 2;
            button1.Text = "Újrakezdés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2278, 1397);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
    }
}
