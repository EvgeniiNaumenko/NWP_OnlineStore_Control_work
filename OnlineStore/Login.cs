using System.Windows.Forms;
using System.Drawing;
using OnlineStore.Forms.Register;
using System.Text.Json;
using System.Text;
using OnlineStore.Models;
using OnlineStore.Forms.UserInterface;
using OnlineStore.Forms;
using System.Net.Http.Json;

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
            RegisterForm registerForm = new RegisterForm(this);
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

            try
            {

                bool isAuthenticated = await AuthenticateUserAsync(userLogin);
                MessageBox.Show(isAuthenticated ? "555Àâòîðèçàöèÿ ïðîøëà óñïåøíî!" : "Логин или пароль неверен.");
                if (isAuthenticated)
                {
                    MainMenuForm menuForm = new MainMenuForm();
                    menuForm.Show();
                    this.Hide();
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"123Îøèáêà HTTP: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"123Ïðîèçîøëà îøèáêà: {ex.Message}");
            }
        }

        public static async Task<bool> AuthenticateUserAsync(UserLogin login)
        {
            var url = "https://localhost:7284/users/authenticate";

            var response = await client.PostAsJsonAsync(url, login);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Dictionary<string, bool>>();
                return result != null && result.TryGetValue("authenticated", out bool isAuthenticated) && isAuthenticated;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UserInterfaceForm userInterForm = new UserInterfaceForm();
            //userInterForm.Show();


            MainMenuForm menuForm = new MainMenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}

