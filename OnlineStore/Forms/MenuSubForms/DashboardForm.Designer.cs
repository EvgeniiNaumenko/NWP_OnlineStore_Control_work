using FontAwesome.Sharp;

namespace OnlineStore.Forms.MenuSubForms
{
    partial class DashboardForm
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
            FilterPanel = new Panel();
            ClearBtn = new IconButton();
            FilterBtn = new IconButton();
            PagesPanel = new Panel();
            BackwardBtn = new IconButton();
            ForwardBtn = new IconButton();
            FilterProductsPanel = new FlowLayoutPanel();
            FilterPanel.SuspendLayout();
            PagesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FilterPanel
            // 
            FilterPanel.BackColor = Color.FromArgb(34, 33, 68);
            FilterPanel.Controls.Add(ClearBtn);
            FilterPanel.Controls.Add(FilterBtn);
            FilterPanel.Dock = DockStyle.Top;
            FilterPanel.Location = new Point(0, 0);
            FilterPanel.Margin = new Padding(3, 2, 3, 2);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(745, 40);
            FilterPanel.TabIndex = 0;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearBtn.BackColor = Color.FromArgb(34, 33, 68);
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.IconChar = IconChar.Broom;
            ClearBtn.IconColor = Color.Gainsboro;
            ClearBtn.IconFont = IconFont.Auto;
            ClearBtn.IconSize = 40;
            ClearBtn.Location = new Point(696, 0);
            ClearBtn.Margin = new Padding(9, 8, 9, 8);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Padding = new Padding(4, 8, 4, 4);
            ClearBtn.Size = new Size(44, 36);
            ClearBtn.TabIndex = 0;
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterBtn.BackColor = Color.FromArgb(34, 33, 68);
            FilterBtn.FlatAppearance.BorderSize = 0;
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.IconChar = IconChar.Search;
            FilterBtn.IconColor = Color.Gainsboro;
            FilterBtn.IconFont = IconFont.Auto;
            FilterBtn.IconSize = 40;
            FilterBtn.Location = new Point(648, 0);
            FilterBtn.Margin = new Padding(9, 8, 9, 8);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Padding = new Padding(4, 8, 4, 4);
            FilterBtn.Size = new Size(44, 36);
            FilterBtn.TabIndex = 0;
            FilterBtn.UseVisualStyleBackColor = false;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // PagesPanel
            // 
            PagesPanel.BackColor = Color.FromArgb(34, 33, 68);
            PagesPanel.Controls.Add(BackwardBtn);
            PagesPanel.Controls.Add(ForwardBtn);
            PagesPanel.Dock = DockStyle.Bottom;
            PagesPanel.Location = new Point(0, 417);
            PagesPanel.Name = "PagesPanel";
            PagesPanel.Size = new Size(851, 50);
            PagesPanel.TabIndex = 0;
            // 
            // BackwardBtn
            // 
            BackwardBtn.Anchor = AnchorStyles.Bottom;
            BackwardBtn.BackColor = Color.FromArgb(34, 33, 68);
            BackwardBtn.FlatAppearance.BorderSize = 0;
            BackwardBtn.FlatStyle = FlatStyle.Flat;
            BackwardBtn.IconChar = IconChar.ArrowLeft;
            BackwardBtn.IconColor = Color.Gainsboro;
            BackwardBtn.IconFont = IconFont.Auto;
            BackwardBtn.IconSize = 40;
            BackwardBtn.Location = new Point(159, 10);
            BackwardBtn.Margin = new Padding(10);
            BackwardBtn.Name = "BackwardBtn";
            BackwardBtn.Padding = new Padding(5, 10, 5, 5);
            BackwardBtn.Size = new Size(250, 30);
            BackwardBtn.TabIndex = 0;
            BackwardBtn.UseVisualStyleBackColor = false;
            BackwardBtn.Click += BackwardBtn_Click;
            // 
            // ForwardBtn
            // 
            ForwardBtn.Anchor = AnchorStyles.Bottom;
            ForwardBtn.BackColor = Color.FromArgb(34, 33, 68);
            ForwardBtn.FlatAppearance.BorderSize = 0;
            ForwardBtn.FlatStyle = FlatStyle.Flat;
            ForwardBtn.IconChar = IconChar.ArrowRight;
            ForwardBtn.IconColor = Color.Gainsboro;
            ForwardBtn.IconFont = IconFont.Auto;
            ForwardBtn.IconSize = 40;
            ForwardBtn.Location = new Point(429, 10);
            ForwardBtn.Margin = new Padding(10);
            ForwardBtn.Name = "ForwardBtn";
            ForwardBtn.Padding = new Padding(5, 10, 5, 5);
            ForwardBtn.Size = new Size(250, 30);
            ForwardBtn.TabIndex = 0;
            ForwardBtn.UseVisualStyleBackColor = false;
            ForwardBtn.Click += ForwardBtn_Click;
            // 
            // FilterProductsPanel
            // 
            FilterProductsPanel.AutoScroll = true;
            FilterProductsPanel.Dock = DockStyle.Fill;
            FilterProductsPanel.Location = new Point(0, 40);
            FilterProductsPanel.Margin = new Padding(3, 2, 3, 2);
            FilterProductsPanel.Name = "FilterProductsPanel";
            FilterProductsPanel.Size = new Size(745, 316);
            FilterProductsPanel.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(745, 356);
            Controls.Add(FilterProductsPanel);
            Controls.Add(FilterPanel);
            Name = "DashboardForm";
            Text = "Dashboard";
            FilterPanel.ResumeLayout(false);
            PagesPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel FilterPanel;
        private Panel PagesPanel;
        private IconButton ClearBtn;
        private IconButton FilterBtn;
        private IconButton BackwardBtn;
        private IconButton ForwardBtn;
        private FlowLayoutPanel FilterProductsPanel;
    }
}