﻿namespace linq11
{
    partial class UserControl2
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(51, 191);
            listBox1.Margin = new Padding(7, 8, 7, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(346, 660);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 82);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(493, 87);
            dataGridView1.Margin = new Padding(7, 8, 7, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(789, 771);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(51, 872);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 47);
            textBox2.TabIndex = 6;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "UserControl2";
            Size = new Size(1336, 940);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
    }
}
