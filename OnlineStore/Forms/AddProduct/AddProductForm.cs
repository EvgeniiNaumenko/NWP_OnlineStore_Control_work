using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Models;

namespace OnlineStore.Forms.AddProduct
{
    public partial class AddProductForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static int _userId;
        public AddProductForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        public async Task<bool> AddNewProductAsync(ProductRequest productRequest)
        {
            var url = "https://localhost:7284/products/add";
            var response = await client.PostAsJsonAsync(url, productRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Dictionary<string, bool>>();
                return result != null && result.TryGetValue("added", out bool isAdded) && isAdded;
            }
            return false;

        }

        public bool AreTextBoxesNotEmpty()
        {
            TextBox[] textBoxes = { PhotoPathTextBox, NameTextBox, DescriptionTextBox, PriceTextBox, CategoryTextBox };

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                    return false;
                }
            }
            return true;
        }
        private void AddPhotoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;";
                openFileDialog.Title = "Выберите изображение";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PhotoPathTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private async void AddProductBtn_Click(object sender, EventArgs e)
        {
            var url = "https://localhost:7284/products/add";
            if (AreTextBoxesNotEmpty())
            {
                string imagePath = PhotoPathTextBox.Text;
                byte[] imgBytes = File.ReadAllBytes(imagePath);

                var productRequest = new ProductRequest
                {
                    Name = NameTextBox.Text,
                    Category = CategoryTextBox.Text,
                    Price = decimal.Parse(PriceTextBox.Text),
                    Description = DescriptionTextBox.Text,
                    UserId = _userId,
                    Image = imgBytes
                };

                var success = await AddNewProductAsync(productRequest);
                MessageBox.Show(success ? "Product add!" : "Server is not responding");
                if (success)
                {
                    this.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
