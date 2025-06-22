
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel;

public class ToDoViewModel : INotifyPropertyChanged
{
    public ObservableCollection<TaskViewModel> Tasks {  get; set; }

    private string textTask;
    public string TextTask 
    {
        get => textTask;
        set
        {
            textTask = value;
            OnPropertyChanged();
        }
    }

    public ToDoViewModel()
    {
        Tasks =
        [
            new()
            {
                Name = "Сделать дз по WPF",
                IsComplete = false
            },
            new()
            {
                Name = "Пройти курс по C#",
                IsComplete = true
            }
        ];

        AddTaskCommand = new(AddTask);
        //ToggleTaskCompletionCommand = new(ToggleTaskCompletion);
    }
    //public RelayCommand ToggleTaskCompletionCommand { get; set; }
    public RelayCommand AddTaskCommand { get; set; }

    //private void ToggleTaskCompletion(object? parameter)
    //{
    //    if (parameter is TaskViewModel taskViewModel)
    //    {
    //        taskViewModel.IsComplete = !taskViewModel.IsComplete;
    //    }
    //}

    public void SaveTasksToFile(string filePath)
    {
        //var filePath = "C:\\Users\\Shalim\\source\\repos\\WPF_CSharp_DZ\\Model\\jsTasks.json";

        var tasksModel = new List<TaskModel>();

        foreach (var task in Tasks)
        {
            var taskModel = new TaskModel()
            {
                Name = task.Name,
                IsComplete = task.IsComplete
            };

            tasksModel.Add(taskModel);
        }

        new TaskManager().Write(tasksModel, filePath);
    }

    public void LoadTaskFromFile(string filePath)
    {
        var tasksModel = new TaskManager().Read(filePath);

        Tasks.Clear();
        foreach (var task in tasksModel)
        {
            var taskViewModel = new TaskViewModel()
            {
                Name= task.Name,
                IsComplete = task.IsComplete
            };

            Tasks.Add(taskViewModel);
        }
    }

    private void AddTask(object? parameter)
    {
        var taskViewModel = new TaskViewModel()
        {
            Name = TextTask,
        };

        TextTask = string.Empty;
        Tasks.Add(taskViewModel);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
