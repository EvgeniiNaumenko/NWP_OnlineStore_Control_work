using FontAwesome.Sharp;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Forms.AddProduct;

namespace OnlineStore.Forms.MenuSubForms
{
    public partial class MySalesForm : Form
    {
        public static List<Product> myProducts;
        public MySalesForm()
        {
            InitializeComponent();
            _ = LoadProductsByUserIdAsync(Global.userId);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(Global.userId); //исправить // исправльно на globaluserId
            addProductForm.Show();
        }

        //public async Task LoadProductsByUserIdAsync(int userId)
        //{
        //    var url = $"https://localhost:7284/products/user/{userId}";
        //    using var client = new HttpClient();
        //    myProducts = await client.GetFromJsonAsync<List<Product>>(url);
        //}
        public async Task LoadProductsByUserIdAsync(int userId)
        {
            var url = $"{Global.serverUrl}products/user/{userId}";
            myProducts = await Global.httpClient.GetFromJsonAsync<List<Product>>(url);
        }


        private async void CreateCards(List<Product> list)
        {
            MyProductsPanel.Controls.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                // Создаём панель для карточки
                Panel cardPanel = new Panel
                {
                    Size = new Size(300, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.MintCream,
                    Margin = new Padding(25),
                    Padding = new Padding(5),
                    Tag = i 
                };

                // Создаём PictureBox для изображения
                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = cardPanel.Height / 2,
                    Dock = DockStyle.Top,
                };

                // Загрузка изображения из URL
                string imageUrl = list[i].imageUrl;
                try
                {
                    var imageStream = await Global.httpClient.GetStreamAsync(imageUrl);
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
                    Text =list[i].Name.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.BottomLeft,
                    Font = new Font("Arial",16,FontStyle.Bold| FontStyle.Underline),
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

                // Создаём первую кнопку
                //Button editBtn = new Button
                //{
                //    Text = "Редактировать",
                //    Dock = DockStyle.Bottom,
                //    Size = new Size(70, 30),
                //    Margin = new Padding(5),
                //    BackColor = Color.FromArgb(41, 128, 185),
                //    FlatStyle = FlatStyle.Flat,
                //    Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                //    ForeColor = Color.White,
                //    Tag = i 
                //};
                // Создаём первую кнопку
                Button deleteBtn = new Button
                {
                    Text = "Удалить",
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
                        MessageBox.Show("Продукт успешно удален.");
                        myProducts.RemoveAll(p => p.Id == productId);
                        CreateCards(myProducts);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить продукт.");
                    }
                };

                cardPanel.Controls.Add(descriptionTextBox);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(nameLabel);
                cardPanel.Controls.Add(pictureBox);
                cardPanel.Controls.Add(priceLabel);
                //cardPanel.Controls.Add(editBtn);
                cardPanel.Controls.Add(deleteBtn);

                MyProductsPanel.Controls.Add(cardPanel);

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            CreateCards(myProducts);
        }

        //public async Task<bool> DeleteProductAsync(int productId)
        //{
        //    var url = $"https://localhost:7284/products/delete/{productId}";
        //    using var client = new HttpClient();

        //    var response = await client.DeleteAsync(url);
        //    return response.IsSuccessStatusCode;
        //}
        public async Task<bool> DeleteProductAsync(int productId)
        {
            var url = $"{Global.serverUrl}products/delete/{productId}";

            var response = await Global.httpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }



        //private async void CreateCards(int numberOfCards)
        //{
        //    MyProductsPanel.Controls.Clear(); // Очищаем панель перед добавлением новых карточек

        //    for (int i = 0; i < numberOfCards; i++)
        //    {
        //        // Создаём панель для карточки
        //        Panel cardPanel = new Panel
        //        {
        //            Size = new Size(300,400),
        //            BorderStyle = BorderStyle.FixedSingle,
        //            BackColor = Color.MintCream,
        //            Margin = new Padding(25),
        //            Padding = new Padding(5),
        //            Tag = i // Сохраняем номер карточки в Tag для идентификации
        //        };

        //        // Создаём PictureBox для изображения
        //        PictureBox pictureBox = new PictureBox
        //        {
        //            SizeMode = PictureBoxSizeMode.StretchImage,
        //            Height = cardPanel.Height/2,
        //            Dock = DockStyle.Top,
        //        };

        //        // Загрузка изображения из URL
        //        string imageUrl = "https://github.com/EvgeniiNaumenko/QuizChatBotImages/blob/main/images/cartoonQuiz/1.jpg?raw=true";
        //        try
        //        {
        //            using (var httpClient = new HttpClient())
        //            {
        //                var imageStream = await httpClient.GetStreamAsync(imageUrl);
        //                pictureBox.Image = Image.FromStream(imageStream);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
        //            // Вы можете установить изображение по умолчанию, если загрузка не удалась
        //            pictureBox.Image = Image.FromFile("path_to_default_image.jpg"); // Укажите путь к изображению по умолчанию
        //        }
        //        TextBox descriptionTextBox = new TextBox
        //        {
        //            Multiline = true,
        //            ScrollBars = ScrollBars.Vertical,
        //            Text = $"Описание карто qqqqqqqqq qqqqqqqqqqq qqqqqqqqqqqqqqqqqqq qqqqq qqqqqqq qqqqqqq qqqqqqqqqqqqqqq qqqqqqqqqqqq qqqqqqqqqqqqqq qqqqqqqqqqq qqqqqqqqqqqqчки {i + 1}",
        //            ReadOnly = true,
        //            Dock = DockStyle.Fill,
        //        };

        //        Label priceLabel = new Label
        //        {
        //            Text = $"Price: {i}",
        //            Dock = DockStyle.Bottom,
        //            TextAlign = ContentAlignment.BottomLeft,
        //            //Padding = new Padding(5),
        //            AutoSize = true

        //        };

        //        // Создаём первую кнопку
        //        Button button1 = new Button
        //        {
        //            Text = "Редактировать",
        //            Dock = DockStyle.Bottom,
        //            Size = new Size(70, 30),
        //            Margin = new Padding(5),
        //            BackColor = Color.FromArgb(41, 128, 185),
        //            FlatStyle = FlatStyle.Flat,
        //            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
        //            ForeColor = Color.White,
        //            Tag = i // Сохраняем номер карточки в Tag для идентификации
        //        };
        //        // Создаём первую кнопку
        //        Button button2 = new Button
        //        {
        //            Text = "Удалить",
        //            Dock = DockStyle.Bottom,
        //            Size = new Size(70, 30),
        //            Margin = new Padding(5),
        //            BackColor = Color.FromArgb(41, 128, 185),
        //            FlatStyle = FlatStyle.Flat,
        //            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
        //            ForeColor = Color.White,
        //            Tag = i // Сохраняем номер карточки в Tag для идентификации
        //        };
        //        // Добавляем элементы в панель карточки
        //        cardPanel.Controls.Add(descriptionTextBox);
        //        cardPanel.Controls.Add(pictureBox);
        //        cardPanel.Controls.Add(priceLabel);
        //        cardPanel.Controls.Add(button1); // Внизу над второй кнопкой
        //        cardPanel.Controls.Add(button2); // Внизу над второй кнопкой
        //        // Добавляем карточку в основную панель
        //        MyProductsPanel.Controls.Add(cardPanel);
        //    }
        //}
    }
}

