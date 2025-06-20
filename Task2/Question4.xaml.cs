using System.Windows;

namespace Task2;

/// <summary>
/// Логика взаимодействия для Question4.xaml
/// </summary>
public partial class Question4 : Window
{
    private List<Window> _questions;
    private QuestionContext _questionContext;
    public Question4(List<Window> questions, QuestionContext questionContext)
    {
        InitializeComponent();

        _questions = questions;

        _questionContext = questionContext;
    }

    private void EndButton_Click(object sender, RoutedEventArgs e)
    {
        if (q4Answer1.IsChecked == false
            && q4Answer2.IsChecked == false
            && q4Answer3.IsChecked == false
            && q4Answer4.IsChecked == false)
        {
            MessageBox.Show("Выберите вариант ответа!");

            return;
        }

        if (q4Answer1.IsChecked == true
            && q4Answer3.IsChecked == true
            && q4Answer2.IsChecked == false
            && q4Answer4.IsChecked == false)
        {
            _questionContext.CorrectAnswers++;
        }

        MessageBox.Show($"Тест пройден\n\nПравильных ответов {_questionContext.CorrectAnswers} из 4");

        Application.Current.Shutdown();
    }
}
