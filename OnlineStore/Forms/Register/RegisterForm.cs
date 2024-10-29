using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.Forms.UserInterface;
using OnlineStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineStore.Forms.Register
{
    public partial class RegisterForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (AreTextBoxesNotEmpty())
            {
                var user = new User
                {
                    Login = LoginTB.Text,
                    Password = PasswordTB.Text,
                    Name = NameTB.Text,
                    Surname = SurnameTB.Text,
                    Address = AddressTB.Text,
                    PhoneNumber = PhoneNumberTB.Text
                };

                var success = await RegisterUserAsync(user);
                Console.WriteLine(success ? "Регистрация прошла успешно!" : "Пользователь с таким логином уже существует.");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private bool AreTextBoxesNotEmpty()
        {

            System.Windows.Forms.TextBox[] textBoxes = { LoginTB, PasswordTB, NameTB, SurnameTB, AddressTB, PhoneNumberTB };

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

        public static async Task<bool> RegisterUserAsync(User user)
        {
            var url = "http://localhost:5000/users/register"; // поменять на свой адрес
            var jsonContent = JsonSerializer.Serialize(user);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<RegistrationResponse>(responseString);
                return result?.Registered ?? false;
            }

            return false;
        }
    }
}
