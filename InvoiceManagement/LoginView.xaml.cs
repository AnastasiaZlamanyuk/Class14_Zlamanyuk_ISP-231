using System.Windows;
using System.Windows.Controls;

namespace InvoiceManagement
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;
            string envPw = "Teliv";
            switch (envPw)
            {
                case null:
                    MessageBox.Show("Not found.");
                    break;
                case var pw when pw == passwordEntered:
                    MessageBox.Show("Введён правильный пароль");
                    break;
                default:
                    MessageBox.Show("Введён неправильный пароль");
                    break;
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
