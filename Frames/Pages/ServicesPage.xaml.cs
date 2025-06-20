using System.IO;
using System.Windows.Controls;

namespace Frames.Pages;

/// <summary>
/// Логика взаимодействия для ServicesPage.xaml
/// </summary>
public partial class ServicesPage : Page
{
    public ServicesPage()
    {
        InitializeComponent();

        servicesPage.Text = File.ReadAllText("C:\\Users\\Shalim\\source\\repos\\WPF_CSharp_DZ\\Frames\\Pages\\Files\\Products.txt");
    }
}
