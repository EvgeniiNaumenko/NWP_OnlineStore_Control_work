using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.Forms.UserInterface
{
    public partial class UserInterfaceForm : Form
    {
        public UserInterfaceForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCards(12);
        }

        private void CreateCards(int numberOfCards)
        {
            flowLayoutPanel1.Controls.Clear(); // Очищаем панель перед добавлением новых карточек

            for (int i = 0; i < numberOfCards; i++)
            {
                // Создаём панель для карточки
                Panel cardPanel = new Panel
                {
                    Size = new Size(200, 300),
                    Margin = new Padding(10),
                    BackColor = Color.MintCream,
                    Tag = i // Сохраняем номер карточки в Tag для идентификации
                };

                // Создаём PictureBox для изображения
                PictureBox pictureBox = new PictureBox
                {
                    //Image = Image.FromFile("D:\\ЖЕНЯ\\Обучение\\курс\\img\\photo_2023-07-20_12-01-53.jpg"), // Укажите путь к изображению
                    Image = Image.FromFile("C:\\Users\\admin\\Desktop\\Coollama.jpeg"), // Укажите путь к изображению
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 150
                };

                // Создаём Label для описания
                Label descriptionLabel = new Label
                {
                    Text = $"Описание карточки {i + 1}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(5),
                    AutoSize = true
                };
                Label priceLabel = new Label
                {
                    Text = $"Price: {i}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(5),
                    AutoSize = true
                };

                // Создаём первую кнопку
                Button button1 = new Button
                {
                    Text = "Кнопка 1",
                    Dock = DockStyle.Bottom,
                    Size = new Size(70,30),
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(41, 128, 185),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.White,
                    Tag = i // Сохраняем номер карточки в Tag для идентификации
                };
                //button1.Click += Button1_Click; // Добавляем обработчик нажатия

                // Создаём вторую кнопку
                Button button2 = new Button
                {

                    Text = "Кнопка 2",
                    Dock = DockStyle.Bottom,
                    Size = new Size(70, 30),
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(41, 128, 185),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.White,
                    Tag = i // Сохраняем номер карточки в Tag для идентификации
                };
                //button2.Click += Button2_Click; // Добавляем обработчик нажатия

                // Добавляем элементы в панель карточки
                cardPanel.Controls.Add(button2); // Внизу
                cardPanel.Controls.Add(button1); // Внизу над второй кнопкой
                cardPanel.Controls.Add(descriptionLabel);
                cardPanel.Controls.Add(priceLabel);
                cardPanel.Controls.Add(pictureBox);

                // Добавляем карточку в основную панель
                flowLayoutPanel1.Controls.Add(cardPanel);
            }
        }

        //// Обработчик для кнопки 1
        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    if (sender is Button button)
        //    {
        //        int cardId = (int)(button.Tag ?? 0);
        //        MessageBox.Show($"Кнопка 1 на карточке {cardId + 1} нажата!");
        //    }
        //}

        //// Обработчик для кнопки 2
        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    if (sender is Button button)
        //    {
        //        int cardId = (int)(button.Tag ?? 0);
        //        MessageBox.Show($"Кнопка 2 на карточке {cardId + 1} нажата!");
        //    }
        //}


    }
}
