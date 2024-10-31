namespace OnlineStore.Forms
{
    partial class iconButton5Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel MyCartPanel;
        private System.Windows.Forms.Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label totalPriceLabel;

        private void InitializeComponent()
        {
            MyCartPanel = new FlowLayoutPanel();
            titleLabel = new Label();
            totalPriceLabel = new Label();
            SuspendLayout();

            // MyCartPanel
            MyCartPanel.AutoScroll = true;
            MyCartPanel.Dock = DockStyle.Fill;
            MyCartPanel.Location = new Point(0, 38);
            MyCartPanel.Name = "MyCartPanel";
            MyCartPanel.Padding = new Padding(10);
            MyCartPanel.Size = new Size(700, 431);
            MyCartPanel.TabIndex = 0;

            // titleLabel
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(700, 38);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "My Cart";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            // totalPriceLabel
            totalPriceLabel.Dock = DockStyle.Bottom;
            totalPriceLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            totalPriceLabel.ForeColor = Color.White;
            totalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            totalPriceLabel.Text = "Total Price: $0";
            totalPriceLabel.Size = new Size(700, 30);
            totalPriceLabel.TabIndex = 2;

            // iconButton5Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(700, 500);
            Controls.Add(MyCartPanel);
            Controls.Add(totalPriceLabel);
            Controls.Add(titleLabel);
            Name = "iconButton5Form";
            Text = "MyCart";
            ResumeLayout(false);
        }


        //private void InitializeComponent()
        //{
        //    MyCartPanel = new FlowLayoutPanel();
        //    titleLabel = new Label();
        //    SuspendLayout();
        //    // 
        //    // MyCartPanel
        //    // 
        //    MyCartPanel.AutoScroll = true;
        //    MyCartPanel.Dock = DockStyle.Fill;
        //    MyCartPanel.Location = new Point(0, 38);
        //    MyCartPanel.Name = "MyCartPanel";
        //    MyCartPanel.Padding = new Padding(10);
        //    MyCartPanel.Size = new Size(700, 431);
        //    MyCartPanel.TabIndex = 0;
        //    // 
        //    // titleLabel
        //    // 
        //    titleLabel.Dock = DockStyle.Top;
        //    titleLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        //    titleLabel.ForeColor = SystemColors.Control;
        //    titleLabel.Location = new Point(0, 0);
        //    titleLabel.Name = "titleLabel";
        //    titleLabel.Size = new Size(700, 38);
        //    titleLabel.TabIndex = 1;
        //    titleLabel.Text = "My Cart";
        //    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
        //    // 
        //    // iconButton5Form
        //    // 
        //    AutoScaleDimensions = new SizeF(7F, 15F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    BackColor = Color.FromArgb(34, 33, 74);
        //    ClientSize = new Size(700, 469);
        //    Controls.Add(MyCartPanel);
        //    Controls.Add(titleLabel);
        //    Name = "iconButton5Form";
        //    Text = "MyCart";
        //    ResumeLayout(false);
        //}
    }
}
