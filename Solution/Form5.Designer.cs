﻿namespace Oksana
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(390, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(445, 397);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(330, 456);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.button1.Location = new System.Drawing.Point(713, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить текущего абитуриента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(464, 519);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(13, 20);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "0";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(324, 570);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Укажите фамилию абитуриента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Укажите имя абитуриента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label3.Location = new System.Drawing.Point(18, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Укажите отчество абитуриента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label4.Location = new System.Drawing.Point(18, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Укажите набранный балл по математике";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label5.Location = new System.Drawing.Point(18, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Укажите набранный балл по украинскому языку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label6.Location = new System.Drawing.Point(18, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Укажите набранный балл физике";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label7.Location = new System.Drawing.Point(12, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(446, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Высчитывание рейтингового балла автоматически";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F);
            this.label8.Location = new System.Drawing.Point(19, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Готовность учиться на контракте";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(392, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Добавление нового абитуриента";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 604);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}