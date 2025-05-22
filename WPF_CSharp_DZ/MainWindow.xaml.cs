using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_CSharp_DZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valueTBox.Text))
            {
                MessageBox.Show("Текстовое поле не заполнено");
            }
            else
            {
                usersList.Items.Add(valueTBox.Text);
                valueTBox.Text = string.Empty;
            }
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                usersList.Items.Remove(usersList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Элемент для удаления не выбран");
            }
        }
    }
}