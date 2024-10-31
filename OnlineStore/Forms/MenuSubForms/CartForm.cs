using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Models;
using OnlineStore.Models.Cart;

namespace OnlineStore.Forms
{
    public partial class CartForm : Form
    {
        public static List<Product> myProducts;

        public CartForm()
        {
            InitializeComponent();
            _ = LoadCartItemsByUserIdAsync(Global.userId);
        }

        private async Task LoadCartItemsByUserIdAsync(int userId)
        {
            var url = $"{Global.serverUrl}cart/user/{userId}";
            var cartItems = await Global.httpClient.GetFromJsonAsync<List<CartItem>>(url);
            myProducts = cartItems.Select(ci => ci.Product).ToList();

            CreateCards(myProducts);
            UpdateTotalPrice();
        }

        private async void CreateCards(List<Product> list)
        {
            MyCartPanel.Controls.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Panel cardPanel = new Panel
                {
                    Size = new Size(300, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.MintCream,
                    Margin = new Padding(25),
                    Padding = new Padding(5),
                    Tag = i
                };

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = cardPanel.Height / 2,
                    Dock = DockStyle.Top,
                };

                // загрузка картинок
                string imageUrl = list[i].imageUrl;
                try
                {
                    var imageStream = await Global.httpClient.GetStreamAsync(imageUrl);
                    pictureBox.Image = Image.FromStream(imageStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }

                TextBox descriptionTextBox = new TextBox
                {
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    Text = $"{list[i].Name} \n {list[i].Category} \n {list[i].Description}",
                    ReadOnly = true,
                    BackColor = Color.MintCream,
                    BorderStyle = BorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {list[i].Price}",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial", 14, FontStyle.Italic),
                    AutoSize = true
                };

                Label nameLabel = new Label
                {
                    Text = list[i].Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline),
                    AutoSize = true
                };

                Button deleteBtn = new Button
                {
                    Text = "Delete",
                    Dock = DockStyle.Bottom,
                    Size = new Size(70, 30),
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(41, 128, 185),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.White,
                    Tag = i
                };
                deleteBtn.Click += async (s, e) =>
                {
                    int productId = list[(int)((Button)s).Tag].Id;
                    bool deleted = await DeleteProductAsync(productId);
                    if (deleted)
                    {
                        MessageBox.Show("The product has been successfully removed from the cart.");
                        myProducts.RemoveAll(p => p.Id == productId);
                        CreateCards(myProducts);
                        UpdateTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove product from cart.");
                    }
                };

                cardPanel.Controls.Add(descriptionTextBox);
                cardPanel.Controls.Add(nameLabel);
                cardPanel.Controls.Add(pictureBox);
                cardPanel.Controls.Add(priceLabel);
                cardPanel.Controls.Add(deleteBtn);

                MyCartPanel.Controls.Add(cardPanel);
            }
        }
        private async Task<bool> DeleteProductAsync(int productId)
        {
            var url = $"{Global.serverUrl}cart/remove?userId={Global.userId}&productId={productId}";
            var response = await Global.httpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = myProducts.Sum(product => product.Price);
            totalPriceLabel.Text = $"Total Price: ${totalPrice}";
        }
    }
}
