using System.Windows;

namespace Task2;

/// <summary>
/// Логика взаимодействия для Question1.xaml
/// </summary>
public partial class Question1 : Window
{
    private List<Window> _questions;
    private QuestionContext _questionContext;
    public Question1(List<Window> questions, QuestionContext questionContext)
    {
        InitializeComponent();

        _questions = questions;

        _questionContext = questionContext;
    }

    private void FutherButton_Click(object sender, RoutedEventArgs e)
    {
        if (q1Answer1.IsChecked == false
            && q1Answer2.IsChecked == false
            && q1Answer3.IsChecked == false
            && q1Answer4.IsChecked == false)
        {
            MessageBox.Show("Выберите вариант ответа!");

            return;
        }

        if (q1Answer1.IsChecked == true)
        {
            _questionContext.CorrectAnswers++;
        }

        _questions[_questionContext.QuestionNumber].Show();

        _questionContext.QuestionNumber++;

        Hide();
    }
}
