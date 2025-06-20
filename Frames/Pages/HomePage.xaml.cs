using System.IO;
using System.Windows.Controls;

namespace Frames.Pages;

/// <summary>
/// Логика взаимодействия для HomePage.xaml
/// </summary>
public partial class HomePage : Page
{
    public HomePage()
    {
        InitializeComponent();

        homePage.Text = File.ReadAllText("C:\\Users\\Shalim\\source\\repos\\WPF_CSharp_DZ\\Frames\\Pages\\Files\\Main.txt");
    }
}
