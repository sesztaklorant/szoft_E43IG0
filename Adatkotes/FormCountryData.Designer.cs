﻿namespace Adatkotes
{
    partial class FormCountryData
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Location = new Point(29, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Country Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 131);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Population:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox2.Location = new Point(29, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 222);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Area in km2:";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(29, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(254, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCountryData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 314);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormCountryData";
            Text = "FormCountryData";
            Load += FormCountryData_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private BindingSource bindingSource1;
        private Button button1;
    }
}