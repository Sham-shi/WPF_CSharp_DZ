using System.IO;
using System.Windows.Controls;

namespace Frames.Pages;

/// <summary>
/// Логика взаимодействия для AboutPage.xaml
/// </summary>
public partial class AboutPage : Page
{
    public AboutPage()
    {
        InitializeComponent();

        aboutPage.Text = File.ReadAllText("C:\\Users\\Shalim\\source\\repos\\WPF_CSharp_DZ\\Frames\\Pages\\Files\\About.txt");
    }
}
