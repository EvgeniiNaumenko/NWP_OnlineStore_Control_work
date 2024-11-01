using System.Windows.Forms;
using System.Drawing;
using OnlineStore.Forms.Register;
using System.Text.Json;
using System.Text;
using OnlineStore.Models;
using OnlineStore.Forms;
using System.Net.Http.Json;
using OnlineStore.Forms.MenuSubForms;

namespace OnlineStore
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                int? userId = await AuthenticateUserAsync(userLogin);


                if (userId.HasValue)
                {
                    MainMenuForm menuForm = new MainMenuForm();
                    Global.userId = userId.Value;
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Authentication failed. Please check your credentials.");
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"HTTP Error: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public static async Task<int?> AuthenticateUserAsync(UserLogin login)
        {
            var url = "https://localhost:7284/users/authenticate";

            var response = await client.PostAsJsonAsync(url, login);

            if (response.IsSuccessStatusCode)
            {
                if (response.Content != null)
                {
                    try
                    {
                        int? userId = await response.Content.ReadFromJsonAsync<int?>();
                        return userId;
                    }
                    catch (JsonException)
                    {
                        return null;
                    }
                }
            }
            return null;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //UserInterfaceForm userInterForm = new UserInterfaceForm(this);
            //userInterForm.Show();


            MainMenuForm menuForm = new MainMenuForm();
            menuForm.Show();
            this.Hide();



            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    // ������������� ������ ��� ������ ������ �����������
            //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            //    openFileDialog.Title = "�������� �����������";

            //    // ���������, ������ �� ������������ ����
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        // ���������� ��������� ����������� � PictureBox
            //        //pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            //        MessageBox.Show("good");
            //    }
            //}
        }
    }
}

