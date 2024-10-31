namespace OnlineStore.Forms.MenuSubForms
{
    partial class MySalesForm
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
            AddProductButton = new FontAwesome.Sharp.IconButton();
            MyProductsPanel = new FlowLayoutPanel();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // AddProductButton
            // 
            AddProductButton.BackColor = Color.FromArgb(34, 33, 68);
            AddProductButton.Dock = DockStyle.Top;
            AddProductButton.FlatAppearance.BorderSize = 0;
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.ForeColor = SystemColors.ControlText;
            AddProductButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            AddProductButton.IconColor = Color.Gainsboro;
            AddProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddProductButton.IconSize = 40;
            AddProductButton.ImageAlign = ContentAlignment.TopCenter;
            AddProductButton.Location = new Point(0, 0);
            AddProductButton.Margin = new Padding(10);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Padding = new Padding(5);
            AddProductButton.Size = new Size(629, 50);
            AddProductButton.TabIndex = 0;
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // MyProductsPanel
            // 
            MyProductsPanel.AutoScroll = true;
            MyProductsPanel.Dock = DockStyle.Fill;
            MyProductsPanel.Location = new Point(0, 50);
            MyProductsPanel.Name = "MyProductsPanel";
            MyProductsPanel.Padding = new Padding(10);
            MyProductsPanel.Size = new Size(629, 353);
            MyProductsPanel.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(34, 33, 68);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            UpdateBtn.IconColor = Color.Gainsboro;
            UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UpdateBtn.IconSize = 40;
            UpdateBtn.Location = new Point(0, 0);
            UpdateBtn.Margin = new Padding(10);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Padding = new Padding(5, 10, 5, 5);
            UpdateBtn.Size = new Size(55, 50);
            UpdateBtn.TabIndex = 0;
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // MySalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(629, 403);
            Controls.Add(UpdateBtn);
            Controls.Add(MyProductsPanel);
            Controls.Add(AddProductButton);
            Name = "MySalesForm";
            Text = "MySalesForm";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton AddProductButton;
        private FlowLayoutPanel MyProductsPanel;
        private FontAwesome.Sharp.IconButton UpdateBtn;
    }
}