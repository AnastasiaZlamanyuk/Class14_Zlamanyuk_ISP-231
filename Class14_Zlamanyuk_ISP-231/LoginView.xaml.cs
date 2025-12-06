using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Class14_Zlamanyuk_ISP_231
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string user = username.Text;
            string pas = Password.Password;
            if (user == "student" && pas == "pass123")
            {
                MessageBox.Show($"Добро пожаловать, {user}!");
                username.Text = "";
                Password.Password = "";
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
