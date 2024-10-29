using System.Windows.Forms;
using System.Drawing;
using OnlineStore.Forms.Register;
using System.Text.Json;
using System.Text;
using OnlineStore.Models;

namespace OnlineStore
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            LoginTextBox.BackColor = Color.White;
            LoginPanel.BackColor = Color.White;
            PasswordPanel.BackColor = SystemColors.Control;
            PasswordTextBox.BackColor = SystemColors.Control;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
            PasswordPanel.BackColor = Color.White;
            LoginTextBox.BackColor = SystemColors.Control;
            LoginPanel.BackColor = SystemColors.Control;
        }

        private void PasswordPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var userLogin = new UserLogin
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };

            bool isAuthenticated = await AuthenticateUserAsync(userLogin);
            MessageBox.Show(isAuthenticated ? "Авторизация прошла успешно!" : "Неверный логин или пароль.");
            if (isAuthenticated)
            {
               //TODO переход на USERINTERFACE
            }
        }
        public static async Task<bool> AuthenticateUserAsync(UserLogin login)
        {
            var url = "http://localhost:5000/users/authenticate"; // Укажите адрес вашего сервера
            var jsonContent = JsonSerializer.Serialize(login);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<AuthenticationResponse>(responseString);
                return result?.Authenticated ?? false;
            }

            return false;
        }
    }
}

