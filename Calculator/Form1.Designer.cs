﻿namespace Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 518);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 412);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 412);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(224, 412);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 306);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(118, 306);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(224, 306);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 200);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(118, 200);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumber_Click;
            // 
            // button10
            // 
            button10.Location = new Point(224, 200);
            button10.Name = "button10";
            button10.Size = new Size(100, 100);
            button10.TabIndex = 9;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonNumber_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Info;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(118, 518);
            button11.Name = "button11";
            button11.Size = new Size(100, 100);
            button11.TabIndex = 10;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonClear_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ActiveCaption;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(224, 518);
            button12.Name = "button12";
            button12.Size = new Size(100, 100);
            button12.TabIndex = 11;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += buttonEqual_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.HotTrack;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(330, 200);
            button13.Name = "button13";
            button13.Size = new Size(100, 100);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += buttonAction_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.HotTrack;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(330, 306);
            button14.Name = "button14";
            button14.Size = new Size(100, 100);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += buttonAction_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.HotTrack;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(330, 412);
            button15.Name = "button15";
            button15.Size = new Size(100, 100);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            button15.Click += buttonAction_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.HotTrack;
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(330, 518);
            button16.Name = "button16";
            button16.Size = new Size(100, 100);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonAction_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 135);
            textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(446, 630);
            Controls.Add(textBox1);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox textBox1;
    }
}