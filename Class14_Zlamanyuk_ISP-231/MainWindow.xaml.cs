using System.Windows;

namespace Class14_Zlamanyuk_ISP_231
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new LoginView();
        }
    }
}