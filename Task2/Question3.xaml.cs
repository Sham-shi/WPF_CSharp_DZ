using System.Windows;

namespace Task2;

/// <summary>
/// Логика взаимодействия для Question3.xaml
/// </summary>
public partial class Question3 : Window
{
    private List<Window> _questions;
    private QuestionContext _questionContext;
    public Question3(List<Window> questions, QuestionContext questionContext)
    {
        InitializeComponent();

        _questions = questions;

        _questionContext = questionContext;
    }

    private void FutherButton_Click(object sender, RoutedEventArgs e)
    {
        if (q3Answer1.IsChecked == false
            && q3Answer2.IsChecked == false
            && q3Answer3.IsChecked == false
            && q3Answer4.IsChecked == false)
        {
            MessageBox.Show("Выберите вариант ответа!");

            return;
        }

        if (q3Answer4.IsChecked == true)
        {
            _questionContext.CorrectAnswers++;
        }

        _questions[_questionContext.QuestionNumber].Show();

        _questionContext.QuestionNumber++;

        Hide();
    }
}
