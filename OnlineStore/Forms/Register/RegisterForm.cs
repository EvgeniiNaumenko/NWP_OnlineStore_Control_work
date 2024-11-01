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
using OnlineStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineStore.Forms.Register
{
    public partial class RegisterForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private Login _loginForm;
        public RegisterForm(Login loginForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _loginForm = loginForm;
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
                MessageBox.Show(success ? "Registration was successful!" : "User with this login already exists");
                if(success)
                {
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Close();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }


        // Methods

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
            var url = "https://localhost:7284/users/register";   // Женя

            var response = await client.PostAsJsonAsync(url, user);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<RegistrationResponse>();
                return result != null && result.Registered;
            }

            return false;
        }

    }
}
