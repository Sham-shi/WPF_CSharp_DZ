using Microsoft.Win32;
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

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        var saveFileDialog = new SaveFileDialog();

        if (saveFileDialog.ShowDialog() == true)
        {
            toDoViewModel.SaveTasksToFile(saveFileDialog.FileName);
        }
    }

    private void LoadButton_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == true)
        {
            toDoViewModel.LoadTaskFromFile(openFileDialog.FileName);
        }
    }
}
