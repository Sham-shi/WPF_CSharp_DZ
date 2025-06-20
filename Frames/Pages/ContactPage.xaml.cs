using System.IO;
using System.Windows.Controls;

namespace Frames.Pages;

/// <summary>
/// Логика взаимодействия для ContactPage.xaml
/// </summary>
public partial class ContactPage : Page
{
    public ContactPage()
    {
        InitializeComponent();

        contactPage.Text = File.ReadAllText("C:\\Users\\Shalim\\source\\repos\\WPF_CSharp_DZ\\Frames\\Pages\\Files\\Contacts.txt");
    }
}
