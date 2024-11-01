namespace OnlineStore.Forms
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel MyCartPanel;

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
            totalPriceLabel = new Label();
            SuspendLayout();
            // 
            // MyCartPanel
            // 
            MyCartPanel.AutoScroll = true;
            MyCartPanel.Dock = DockStyle.Fill;
            MyCartPanel.Location = new Point(0, 0);
            MyCartPanel.Name = "MyCartPanel";
            MyCartPanel.Padding = new Padding(10);
            MyCartPanel.Size = new Size(700, 470);
            MyCartPanel.TabIndex = 0;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Dock = DockStyle.Bottom;
            totalPriceLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            totalPriceLabel.ForeColor = Color.White;
            totalPriceLabel.Location = new Point(0, 470);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(700, 30);
            totalPriceLabel.TabIndex = 2;
            totalPriceLabel.Text = "Total Price: $0";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(700, 500);
            Controls.Add(MyCartPanel);
            Controls.Add(totalPriceLabel);
            Name = "CartForm";
            Text = "Cart";
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
