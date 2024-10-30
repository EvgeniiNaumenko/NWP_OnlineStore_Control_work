﻿namespace OnlineStore.Forms.Register
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            PasswordTB = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            NameTB = new TextBox();
            RegisterBtn = new Button();
            BackBtn = new Button();
            PhoneNumberTB = new TextBox();
            AddressTB = new TextBox();
            SurnameTB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LoginTB = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(195, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(95, 154);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(195, 114);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(264, 23);
            PasswordTB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(-591, -161);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(-470, -164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(74, 117);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 1;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(195, 151);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(264, 23);
            NameTB.TabIndex = 2;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(41, 128, 185);
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(85, 333);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(148, 35);
            RegisterBtn.TabIndex = 4;
            RegisterBtn.Text = "REGISTER";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(41, 128, 185);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(384, 333);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(148, 35);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // PhoneNumberTB
            // 
            PhoneNumberTB.Location = new Point(195, 265);
            PhoneNumberTB.Name = "PhoneNumberTB";
            PhoneNumberTB.Size = new Size(264, 23);
            PhoneNumberTB.TabIndex = 8;
            // 
            // AddressTB
            // 
            AddressTB.Location = new Point(195, 226);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(264, 23);
            AddressTB.TabIndex = 9;
            // 
            // SurnameTB
            // 
            SurnameTB.Location = new Point(195, 188);
            SurnameTB.Name = "SurnameTB";
            SurnameTB.Size = new Size(264, 23);
            SurnameTB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(36, 268);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone Number:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(82, 226);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 6;
            label6.Text = "Address:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(77, 191);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 7;
            label7.Text = "Surname:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginTB
            // 
            LoginTB.Location = new Point(195, 79);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(264, 23);
            LoginTB.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(98, 80);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 11;
            label8.Text = "Login:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 434);
            Controls.Add(LoginTB);
            Controls.Add(label8);
            Controls.Add(PhoneNumberTB);
            Controls.Add(AddressTB);
            Controls.Add(SurnameTB);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(BackBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(NameTB);
            Controls.Add(textBox2);
            Controls.Add(PasswordTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "git ad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PasswordTB;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox NameTB;
        private Button RegisterBtn;
        private Button BackBtn;
        private TextBox PhoneNumberTB;
        private TextBox AddressTB;
        private TextBox SurnameTB;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox LoginTB;
        private Label label8;
    }
}