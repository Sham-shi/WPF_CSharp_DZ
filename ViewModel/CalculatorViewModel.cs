
using Model;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ViewModel;

public class CalculatorViewModel : INotifyPropertyChanged
{
    public double A {  get; set; }
    public double B { get; set; }

    private double result;
    public double Result
    {
        get
        {
            return result;
        }
        set
        {
            result = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand SumCommand { get; set; }

    private readonly CalculatorModel calculatorModel = new();

    public CalculatorViewModel()
    {
        SumCommand = new RelayCommand(Sum);
    }

    private void Sum(object? parameter)
    {
        Result = calculatorModel.Sum(A, B);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
