using FontAwesome.Sharp;
using OnlineStore.Models;
using OnlineStore.Models.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.Forms.MenuSubForms
{
    public partial class DashboardForm : Form
    {
        public static List<Product> filterProducts;
        private static readonly HttpClient client = new HttpClient();
        private static int currentPage = 1; 
        private const int PageSize = 12;
        private TextBox nameTextBox;
        private TextBox categoryTextBox;
        private TextBox minPriceTextBox;
        private TextBox maxPriceTextBox;

        public DashboardForm()
        {
            InitializeComponent();
            InitializeSearchPanel();
        }

        private void InitializeSearchPanel()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6, // Пять полей + кнопка поиска
                RowCount = 1,
                Padding = new Padding(0)
            };

            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));

            nameTextBox = new TextBox
            {
                PlaceholderText = "Name",
                Dock = DockStyle.Fill,
                BackColor = this.BackColor,
                Height = 40,
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Gainsboro,
                MinimumSize = new Size(100, 30)

            };
            categoryTextBox = new TextBox
            {
                PlaceholderText = "Category",
                Dock = DockStyle.Fill,
                BackColor = this.BackColor,
                Height = 40,
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Gainsboro,
                MinimumSize = new Size(100, 30)
            };
            minPriceTextBox = new TextBox
            {
                PlaceholderText = "Min Price",
                Dock = DockStyle.Fill,
                BackColor = this.BackColor,
                Height = 40,
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Gainsboro,
                MinimumSize = new Size(100, 30)
            };
            maxPriceTextBox = new TextBox
            {
                PlaceholderText = "Max Price",
                Dock = DockStyle.Fill,
                BackColor = this.BackColor,
                Height = 40,
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Gainsboro,
                MinimumSize = new Size(100, 30)
            };

            tableLayoutPanel.Controls.Add(nameTextBox, 0, 0);
            tableLayoutPanel.Controls.Add(categoryTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(minPriceTextBox, 2, 0);
            tableLayoutPanel.Controls.Add(maxPriceTextBox, 3, 0);


            FilterPanel.Controls.Add(tableLayoutPanel);
            this.Controls.Add(FilterPanel);
        }

        private async Task<List<Product>> FetchFilteredProducts(ProductFilterRequest filterRequest)
        {
            try
            {
                var response = await client.PostAsJsonAsync("https://localhost:7284/products/filter", filterRequest);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Product>>();
                }
                else
                {
                    MessageBox.Show("Ошибка при получении продуктов: " + response.ReasonPhrase);
                    return new List<Product>(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return new List<Product>();
            }
        }


        private async void NextPage()
        {
            currentPage++;
            await LoadProducts();
        }

        private async void PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadProducts(); 
            }
        }
        private async Task LoadProducts()
        {

            var filterRequest = new ProductFilterRequest
            {
                Name = nameTextBox.Text,
                Category = categoryTextBox.Text,
                MinPrice = string.IsNullOrEmpty(minPriceTextBox.Text) ? (decimal?)null : decimal.Parse(minPriceTextBox.Text),
                MaxPrice = string.IsNullOrEmpty(maxPriceTextBox.Text) ? (decimal?)null : decimal.Parse(maxPriceTextBox.Text),
                Page = currentPage,
                PageSize = PageSize
            };

            var products = await FetchFilteredProducts(filterRequest);
            filterProducts = products;
            CreateCards(filterProducts);
        }
        private async void FilterBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadProducts();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            categoryTextBox.Text = "";
            minPriceTextBox.Text = "";
            maxPriceTextBox.Text = "";
        }

        private void BackwardBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private async void CreateCards(List<Product> list)
        {
            FilterProductsPanel.Controls.Clear();

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

                string imageUrl = list[i].imageUrl;
                try
                {
                     var imageStream = await client.GetStreamAsync(imageUrl);
                     pictureBox.Image = Image.FromStream(imageStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
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
                    Text = $"Price: {list[i].Price.ToString()}",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial", 14, FontStyle.Italic),
                    AutoSize = true

                };

                Label nameLabel = new Label
                {
                    Text = list[i].Name.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline),
                    AutoSize = true

                };

                Label categoryLabel = new Label
                {
                    Text = list[i].Name.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial", 14, FontStyle.Italic),
                    AutoSize = true

                };

                Button addBtn = new Button
                {
                    Text = "В корзину",
                    Dock = DockStyle.Bottom,
                    Size = new Size(70, 30),
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(41, 128, 185),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.White,
                    Tag = i
                };
                addBtn.Click += async (s, e) =>
                {
                    int productId = list[(int)((Button)s).Tag].Id;
                    int quantity = 1;
                    int userId = Global.userId; 

                    bool added = await AddProductToCartAsync(userId, productId, quantity);
                    if (added)
                    {
                        MessageBox.Show("Product has been added.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add to cart");
                    }
                };

                cardPanel.Controls.Add(descriptionTextBox);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(nameLabel);
                cardPanel.Controls.Add(pictureBox);
                cardPanel.Controls.Add(priceLabel);
                cardPanel.Controls.Add(addBtn);

                FilterProductsPanel.Controls.Add(cardPanel);
            }

        }

        // Cart add Prod
        private async Task<bool> AddProductToCartAsync(int userId, int productId, int quantity)
        {
            var requestUri = $"{Global.serverUrl}cart/add?userId={userId}&productId={productId}&quantity={quantity}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(requestUri, null);

                return response.IsSuccessStatusCode;
            }
        }


    }
}
