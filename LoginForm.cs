using MySql.Data.MySqlClient;

namespace NeiroModerator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Введите логин и пароль";
                lblError.Visible = true;
                return;
            }

            btnLogin.Enabled = false;

            try
            {
                int userId = Database.Authenticate(login, password);

                if (userId == 0)
                {
                    lblError.Text = "Неверный логин или пароль";
                    lblError.Visible = true;
                    return;
                }

                Session.UserID = userId;
                Session.Login = login;

                Hide();

                using ChatForm moderatorForm = new ChatForm();
                moderatorForm.ShowDialog();

                Close();
            }
            
            catch (MySqlException)
            {
                MessageBox.Show(
                    "Не удалось подключиться к базе данных.",
                    "Ошибка MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
