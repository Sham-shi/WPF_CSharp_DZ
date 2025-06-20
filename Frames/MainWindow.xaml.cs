using Frames.Pages;
using System.Windows;
using System.Windows.Controls;

namespace Frames;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Dictionary<int, Page> pageByNumber = [];

    public MainWindow()
    {
        InitializeComponent();

        var homePage = new HomePage();

        pageByNumber.Add(0, homePage);
        pageByNumber.Add(1, new AboutPage());
        pageByNumber.Add(2, new ContactPage());
        pageByNumber.Add(3, new ServicesPage());

        MyFrame.Navigate(homePage);
    }

    private void NavigateToPage_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var commandParameter = int.Parse(button.CommandParameter.ToString());
        var page = pageByNumber[commandParameter];

        MyFrame.Navigate(page);
    }
}