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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(x.Text) || string.IsNullOrWhiteSpace(y.Text))
            {
                MessageBox.Show("Поле не заполнено");
                result.Text = "";
                return;
            }

            if (double.TryParse(x.Text, out var xNumber) &&
                double.TryParse(y.Text, out var yNumber))
            {
                result.Text = (xNumber + yNumber).ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
                result.Text = "";
            }
        }
    }
}