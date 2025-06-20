using System.Windows;

namespace Task2;

/// <summary>
/// Логика взаимодействия для Question2.xaml
/// </summary>
public partial class Question2 : Window
{
    private List<Window> _questions;
    private QuestionContext _questionContext;
    public Question2(List<Window> questions, QuestionContext questionContext)
    {
        InitializeComponent();

        _questions = questions;

        _questionContext = questionContext;
    }

    private void FutherButton_Click(object sender, RoutedEventArgs e)
    {
        if (q2Answer1.IsChecked == false
            && q2Answer2.IsChecked == false
            && q2Answer3.IsChecked == false
            && q2Answer4.IsChecked == false)
        {
            MessageBox.Show("Выберите вариант ответа!");

            return;
        }

        if (q2Answer3.IsChecked == true
            && q2Answer4.IsChecked == true
            && q2Answer1.IsChecked == false
            && q2Answer2.IsChecked == false)
        {
            _questionContext.CorrectAnswers++;
        }

        _questions[_questionContext.QuestionNumber].Show();

        _questionContext.QuestionNumber++;

        Hide();
    }
}
