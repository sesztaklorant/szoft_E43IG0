namespace Fibonacci
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
            szurkenegyzet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)szurkenegyzet).BeginInit();
            SuspendLayout();
            // 
            // szurkenegyzet
            // 
            szurkenegyzet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            szurkenegyzet.Location = new Point(364, 37);
            szurkenegyzet.Name = "szurkenegyzet";
            szurkenegyzet.RowTemplate.Height = 25;
            szurkenegyzet.Size = new Size(385, 384);
            szurkenegyzet.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szurkenegyzet);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)szurkenegyzet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView szurkenegyzet;
    }
}