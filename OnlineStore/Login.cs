using System.Windows.Forms;
using System.Drawing;
using OnlineStore.Forms.Register;
using System.Text.Json;
using System.Text;
using OnlineStore.Models;
using OnlineStore.Forms.UserInterface;
using OnlineStore.Forms;

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
                MessageBox.Show(isAuthenticated ? "Àâòîðèçàöèÿ ïðîøëà óñïåøíî!" : "Íåâåðíûé ëîãèí èëè ïàðîëü.");
                if (isAuthenticated)
                {
                    //TODO ïåðåõîä íà USERINTERFACE
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Îøèáêà HTTP: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïðîèçîøëà îøèáêà: {ex.Message}");
            }
        }
        public static async Task<bool> AuthenticateUserAsync(UserLogin login)
        {

            var url = "https://localhost:7284/users/authenticate"; // Æåíÿ

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

