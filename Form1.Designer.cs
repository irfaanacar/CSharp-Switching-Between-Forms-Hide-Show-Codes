﻿namespace FormlarArasiGecis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 129);
            label1.Name = "label1";
            label1.Size = new Size(143, 39);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 198);
            label2.Name = "label2";
            label2.Size = new Size(68, 39);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(175, 69);
            label3.Name = "label3";
            label3.Size = new Size(141, 39);
            label3.TabIndex = 2;
            label3.Text = "GİRİŞ PANELİ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleVioletRed;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(175, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 46);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PaleVioletRed;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(175, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 46);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Oswald", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(175, 269);
            button1.Name = "button1";
            button1.Size = new Size(228, 72);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 502);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}