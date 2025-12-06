using DataBinding.Data;
using System.Windows;

namespace DataBinding
{
    public partial class MainWindow : Window
    {

        public List<Person> People = new List<Person>
        {
            new Person{Name = "Denis", Age = 30},
            new Person{Name = "Anton", Age = 18},
            new Person{Name = "Vladimir", Age = 10},
            new Person{Name = "Stas", Age = 50},
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxNames.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxNames.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}