namespace OnlineStore.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            MenuPanel = new Panel();
            SettingsBtn = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            Customer = new FontAwesome.Sharp.IconButton();
            OrdersBtn = new FontAwesome.Sharp.IconButton();
            MySalesBtn = new FontAwesome.Sharp.IconButton();
            DashboardBtn = new FontAwesome.Sharp.IconButton();
            LogoPanel = new Panel();
            LogoHomeBtn = new PictureBox();
            TitleBarPanel = new Panel();
            MaximizeBtn = new Button();
            MinimizeBtn = new Button();
            CloseBtn = new Button();
            TitleOfChildFormLabel = new Label();
            CurrentChildFormIconPicBox = new FontAwesome.Sharp.IconPictureBox();
            ShadowPanel = new Panel();
            DesktopPanel = new Panel();
            pictureBox1 = new PictureBox();
            MenuPanel.SuspendLayout();
            LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoHomeBtn).BeginInit();
            TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentChildFormIconPicBox).BeginInit();
            DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(31, 30, 68);
            MenuPanel.Controls.Add(SettingsBtn);
            MenuPanel.Controls.Add(iconButton5);
            MenuPanel.Controls.Add(Customer);
            MenuPanel.Controls.Add(OrdersBtn);
            MenuPanel.Controls.Add(MySalesBtn);
            MenuPanel.Controls.Add(DashboardBtn);
            MenuPanel.Controls.Add(LogoPanel);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(251, 722);
            MenuPanel.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Dock = DockStyle.Top;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Century Gothic", 10F);
            SettingsBtn.ForeColor = Color.Gainsboro;
            SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            SettingsBtn.IconColor = Color.Gainsboro;
            SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SettingsBtn.IconSize = 32;
            SettingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.Location = new Point(0, 587);
            SettingsBtn.Margin = new Padding(3, 4, 3, 4);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Padding = new Padding(11, 0, 23, 0);
            SettingsBtn.Size = new Size(251, 80);
            SettingsBtn.TabIndex = 7;
            SettingsBtn.Text = "Settings";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Century Gothic", 10F);
            iconButton5.ForeColor = Color.Gainsboro;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Cube;
            iconButton5.IconColor = Color.Gainsboro;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 507);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(11, 0, 23, 0);
            iconButton5.Size = new Size(251, 80);
            iconButton5.TabIndex = 6;
            iconButton5.Text = "iconButton5";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // Customer
            // 
            Customer.Dock = DockStyle.Top;
            Customer.FlatAppearance.BorderSize = 0;
            Customer.FlatStyle = FlatStyle.Flat;
            Customer.Font = new Font("Century Gothic", 10F);
            Customer.ForeColor = Color.Gainsboro;
            Customer.IconChar = FontAwesome.Sharp.IconChar.User;
            Customer.IconColor = Color.Gainsboro;
            Customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Customer.IconSize = 32;
            Customer.ImageAlign = ContentAlignment.MiddleLeft;
            Customer.Location = new Point(0, 427);
            Customer.Margin = new Padding(3, 4, 3, 4);
            Customer.Name = "Customer";
            Customer.Padding = new Padding(11, 0, 23, 0);
            Customer.Size = new Size(251, 80);
            Customer.TabIndex = 5;
            Customer.Text = "Customer";
            Customer.TextAlign = ContentAlignment.MiddleLeft;
            Customer.TextImageRelation = TextImageRelation.ImageBeforeText;
            Customer.UseVisualStyleBackColor = true;
            Customer.Click += Customer_Click;
            // 
            // OrdersBtn
            // 
            OrdersBtn.Dock = DockStyle.Top;
            OrdersBtn.FlatAppearance.BorderSize = 0;
            OrdersBtn.FlatStyle = FlatStyle.Flat;
            OrdersBtn.Font = new Font("Century Gothic", 10F);
            OrdersBtn.ForeColor = Color.Gainsboro;
            OrdersBtn.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            OrdersBtn.IconColor = Color.Gainsboro;
            OrdersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrdersBtn.IconSize = 32;
            OrdersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.Location = new Point(0, 347);
            OrdersBtn.Margin = new Padding(3, 4, 3, 4);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Padding = new Padding(11, 0, 23, 0);
            OrdersBtn.Size = new Size(251, 80);
            OrdersBtn.TabIndex = 4;
            OrdersBtn.Text = "Orders";
            OrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrdersBtn.UseVisualStyleBackColor = true;
            OrdersBtn.Click += OrdersBtn_Click;
            // 
            // MySalesBtn
            // 
            MySalesBtn.Dock = DockStyle.Top;
            MySalesBtn.FlatAppearance.BorderSize = 0;
            MySalesBtn.FlatStyle = FlatStyle.Flat;
            MySalesBtn.Font = new Font("Century Gothic", 10F);
            MySalesBtn.ForeColor = Color.Gainsboro;
            MySalesBtn.IconChar = FontAwesome.Sharp.IconChar.Tag;
            MySalesBtn.IconColor = Color.Gainsboro;
            MySalesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MySalesBtn.IconSize = 32;
            MySalesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MySalesBtn.Location = new Point(0, 267);
            MySalesBtn.Margin = new Padding(3, 4, 3, 4);
            MySalesBtn.Name = "MySalesBtn";
            MySalesBtn.Padding = new Padding(11, 0, 23, 0);
            MySalesBtn.Size = new Size(251, 80);
            MySalesBtn.TabIndex = 3;
            MySalesBtn.Text = "My Sales";
            MySalesBtn.TextAlign = ContentAlignment.MiddleLeft;
            MySalesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            MySalesBtn.UseVisualStyleBackColor = true;
            MySalesBtn.Click += MySalesBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Dock = DockStyle.Top;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Century Gothic", 10F);
            DashboardBtn.ForeColor = Color.Gainsboro;
            DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            DashboardBtn.IconColor = Color.Gainsboro;
            DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashboardBtn.IconSize = 32;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(0, 187);
            DashboardBtn.Margin = new Padding(3, 4, 3, 4);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(11, 0, 23, 0);
            DashboardBtn.Size = new Size(251, 80);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardBtn.UseVisualStyleBackColor = true;
            DashboardBtn.Click += MenuBtn_Click;
            // 
            // LogoPanel
            // 
            LogoPanel.Controls.Add(LogoHomeBtn);
            LogoPanel.Dock = DockStyle.Top;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Margin = new Padding(3, 4, 3, 4);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Padding = new Padding(11, 0, 23, 0);
            LogoPanel.Size = new Size(251, 187);
            LogoPanel.TabIndex = 1;
            // 
            // LogoHomeBtn
            // 
            LogoHomeBtn.Image = Properties.Resources._5277c7140df989d54ebf3ea637037add;
            LogoHomeBtn.Location = new Point(19, 15);
            LogoHomeBtn.Margin = new Padding(3, 4, 3, 4);
            LogoHomeBtn.Name = "LogoHomeBtn";
            LogoHomeBtn.Size = new Size(208, 164);
            LogoHomeBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            LogoHomeBtn.TabIndex = 0;
            LogoHomeBtn.TabStop = false;
            LogoHomeBtn.Click += LogoHomeBtn_Click;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.FromArgb(26, 25, 62);
            TitleBarPanel.Controls.Add(MaximizeBtn);
            TitleBarPanel.Controls.Add(MinimizeBtn);
            TitleBarPanel.Controls.Add(CloseBtn);
            TitleBarPanel.Controls.Add(TitleOfChildFormLabel);
            TitleBarPanel.Controls.Add(CurrentChildFormIconPicBox);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(251, 0);
            TitleBarPanel.Margin = new Padding(3, 4, 3, 4);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Size = new Size(1097, 100);
            TitleBarPanel.TabIndex = 1;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            // 
            // MaximizeBtn
            // 
            MaximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeBtn.FlatAppearance.BorderSize = 0;
            MaximizeBtn.FlatStyle = FlatStyle.Flat;
            MaximizeBtn.Image = (Image)resources.GetObject("MaximizeBtn.Image");
            MaximizeBtn.Location = new Point(1011, 4);
            MaximizeBtn.Margin = new Padding(3, 4, 3, 4);
            MaximizeBtn.Name = "MaximizeBtn";
            MaximizeBtn.Size = new Size(27, 27);
            MaximizeBtn.TabIndex = 3;
            MaximizeBtn.UseVisualStyleBackColor = true;
            MaximizeBtn.Click += MaximizeBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeBtn.FlatAppearance.BorderSize = 0;
            MinimizeBtn.FlatStyle = FlatStyle.Flat;
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.ImageAlign = ContentAlignment.BottomCenter;
            MinimizeBtn.Location = new Point(966, 4);
            MinimizeBtn.Margin = new Padding(3, 4, 3, 4);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(27, 27);
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.UseVisualStyleBackColor = true;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(1055, 4);
            CloseBtn.Margin = new Padding(3, 4, 3, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(27, 27);
            CloseBtn.TabIndex = 3;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // TitleOfChildFormLabel
            // 
            TitleOfChildFormLabel.AutoSize = true;
            TitleOfChildFormLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TitleOfChildFormLabel.ForeColor = Color.Gainsboro;
            TitleOfChildFormLabel.Location = new Point(62, 36);
            TitleOfChildFormLabel.Name = "TitleOfChildFormLabel";
            TitleOfChildFormLabel.Size = new Size(59, 21);
            TitleOfChildFormLabel.TabIndex = 1;
            TitleOfChildFormLabel.Text = "Home";
            // 
            // CurrentChildFormIconPicBox
            // 
            CurrentChildFormIconPicBox.BackColor = Color.FromArgb(26, 25, 62);
            CurrentChildFormIconPicBox.ForeColor = Color.MediumPurple;
            CurrentChildFormIconPicBox.IconChar = FontAwesome.Sharp.IconChar.House;
            CurrentChildFormIconPicBox.IconColor = Color.MediumPurple;
            CurrentChildFormIconPicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CurrentChildFormIconPicBox.IconSize = 37;
            CurrentChildFormIconPicBox.Location = new Point(21, 29);
            CurrentChildFormIconPicBox.Margin = new Padding(3, 4, 3, 4);
            CurrentChildFormIconPicBox.Name = "CurrentChildFormIconPicBox";
            CurrentChildFormIconPicBox.Size = new Size(37, 43);
            CurrentChildFormIconPicBox.TabIndex = 0;
            CurrentChildFormIconPicBox.TabStop = false;
            // 
            // ShadowPanel
            // 
            ShadowPanel.BackColor = Color.FromArgb(26, 24, 58);
            ShadowPanel.Dock = DockStyle.Top;
            ShadowPanel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShadowPanel.Location = new Point(251, 100);
            ShadowPanel.Margin = new Padding(3, 4, 3, 4);
            ShadowPanel.Name = "ShadowPanel";
            ShadowPanel.Size = new Size(1097, 12);
            ShadowPanel.TabIndex = 2;
            // 
            // DesktopPanel
            // 
            DesktopPanel.BackColor = Color.FromArgb(34, 33, 74);
            DesktopPanel.Controls.Add(pictureBox1);
            DesktopPanel.Dock = DockStyle.Fill;
            DesktopPanel.Location = new Point(251, 112);
            DesktopPanel.Margin = new Padding(3, 4, 3, 4);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(1097, 610);
            DesktopPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Coollama;
            pictureBox1.Location = new Point(232, 42);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 722);
            Controls.Add(DesktopPanel);
            Controls.Add(ShadowPanel);
            Controls.Add(TitleBarPanel);
            Controls.Add(MenuPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            MenuPanel.ResumeLayout(false);
            LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoHomeBtn).EndInit();
            TitleBarPanel.ResumeLayout(false);
            TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentChildFormIconPicBox).EndInit();
            DesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel LogoPanel;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton Customer;
        private FontAwesome.Sharp.IconButton OrdersBtn;
        private FontAwesome.Sharp.IconButton MySalesBtn;
        private PictureBox LogoHomeBtn;
        private Panel TitleBarPanel;
        private FontAwesome.Sharp.IconPictureBox CurrentChildFormIconPicBox;
        private Label TitleOfChildFormLabel;
        private Panel ShadowPanel;
        private Panel DesktopPanel;
        private PictureBox pictureBox1;
        private Button CloseBtn;
        private Button MaximizeBtn;
        private Button MinimizeBtn;
    }
}