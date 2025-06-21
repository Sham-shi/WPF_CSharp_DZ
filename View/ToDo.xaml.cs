using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace View;

/// <summary>
/// Логика взаимодействия для ToDo.xaml
/// </summary>
public partial class ToDo : Window
{
    private ToDoViewModel toDoViewModel = new();
    public ToDo()
    {
        InitializeComponent();
        DataContext = toDoViewModel;
    }
}
