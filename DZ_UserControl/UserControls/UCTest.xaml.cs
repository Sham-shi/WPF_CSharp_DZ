using System.Windows.Controls;

namespace DZ_UserControl.UserControls;

/// <summary>
/// Логика взаимодействия для UCTest.xaml
/// </summary>
public partial class UCTest : UserControl
{
    public required string Title { get; set; }
    public required int MaxLength { get; set; }
    public UCTest()
    {
        InitializeComponent();

        DataContext = this;
    }
}
