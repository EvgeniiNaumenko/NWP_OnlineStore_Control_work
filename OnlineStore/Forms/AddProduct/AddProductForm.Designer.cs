namespace OnlineStore.Forms.AddProduct
{
    partial class AddProductForm
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
            BackBtn = new Button();
            AddProductBtn = new Button();
            NameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            PriceTextBox = new TextBox();
            label4 = new Label();
            CategoryTextBox = new TextBox();
            label5 = new Label();
            AddPhotoBtn = new Button();
            PhotoPathTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(41, 128, 185);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(290, 470);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(98, 47);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.FromArgb(41, 128, 185);
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProductBtn.ForeColor = Color.White;
            AddProductBtn.Location = new Point(87, 470);
            AddProductBtn.Margin = new Padding(3, 4, 3, 4);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(197, 47);
            AddProductBtn.TabIndex = 13;
            AddProductBtn.Text = "ADD PRODUCT";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(87, 125);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(301, 27);
            NameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(87, 96);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 8;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(123, 36);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 5;
            label1.Text = "ADD PRODUCT:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(87, 185);
            DescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(301, 27);
            DescriptionTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(87, 156);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 14;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(87, 305);
            PriceTextBox.Margin = new Padding(3, 4, 3, 4);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(301, 27);
            PriceTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(87, 276);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 18;
            label4.Text = "Price:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(87, 245);
            CategoryTextBox.Margin = new Padding(3, 4, 3, 4);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(301, 27);
            CategoryTextBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(87, 216);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 16;
            label5.Text = "Category:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddPhotoBtn
            // 
            AddPhotoBtn.BackColor = Color.FromArgb(41, 128, 185);
            AddPhotoBtn.FlatStyle = FlatStyle.Flat;
            AddPhotoBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddPhotoBtn.ForeColor = Color.White;
            AddPhotoBtn.Location = new Point(88, 415);
            AddPhotoBtn.Margin = new Padding(3, 4, 3, 4);
            AddPhotoBtn.Name = "AddPhotoBtn";
            AddPhotoBtn.Size = new Size(301, 47);
            AddPhotoBtn.TabIndex = 20;
            AddPhotoBtn.Text = "Add Photo";
            AddPhotoBtn.UseVisualStyleBackColor = false;
            AddPhotoBtn.Click += AddPhotoBtn_Click;
            // 
            // PhotoPathTextBox
            // 
            PhotoPathTextBox.Location = new Point(87, 369);
            PhotoPathTextBox.Margin = new Padding(3, 4, 3, 4);
            PhotoPathTextBox.Name = "PhotoPathTextBox";
            PhotoPathTextBox.Size = new Size(301, 27);
            PhotoPathTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(87, 340);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 21;
            label6.Text = "Photo path:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 555);
            Controls.Add(PhotoPathTextBox);
            Controls.Add(label6);
            Controls.Add(AddPhotoBtn);
            Controls.Add(PriceTextBox);
            Controls.Add(label4);
            Controls.Add(CategoryTextBox);
            Controls.Add(label5);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label3);
            Controls.Add(BackBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button AddProductBtn;
        private TextBox NameTextBox;
        private Label label2;
        private Label label1;
        private TextBox DescriptionTextBox;
        private Label label3;
        private TextBox PriceTextBox;
        private Label label4;
        private TextBox CategoryTextBox;
        private Label label5;
        private Button AddPhotoBtn;
        private TextBox PhotoPathTextBox;
        private Label label6;
    }
}