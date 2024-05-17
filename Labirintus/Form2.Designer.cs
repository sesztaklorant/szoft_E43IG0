namespace Labirintus
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Continue;
            button1.Location = new Point(213, 344);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Új játék";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(407, 344);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 1;
            button2.Text = "Kilépés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(704, 41);
            label1.TabIndex = 2;
            label1.Text = "Gratulálok, sikerült beérnie a célba. Vége a játéknak!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 130);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 3;
            label2.Text = "Lépésszám:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 213);
            label3.Name = "label3";
            label3.Size = new Size(135, 41);
            label3.TabIndex = 4;
            label3.Text = "Játékidő:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 130);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 213);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 414);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}