namespace Labirintus
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 1269);
            label1.Name = "label1";
            label1.Size = new Size(34, 41);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 1269);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 1;
            label2.Text = "00:00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 1269);
            label3.Name = "label3";
            label3.Size = new Size(170, 41);
            label3.TabIndex = 2;
            label3.Text = "Lépésszám:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 1269);
            label4.Name = "label4";
            label4.Size = new Size(135, 41);
            label4.TabIndex = 3;
            label4.Text = "Játékidő:";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(1852, 1329);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
