using System.Windows;

namespace Task2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<Window> _questions;
    private QuestionContext _questionContext;
    public MainWindow()
    {
        InitializeComponent();

        _questionContext = new QuestionContext
        {
            QuestionNumber = 0,
            CorrectAnswers = 0
        };

        _questions = [];

        _questions.Add(new Question1(_questions, _questionContext));
        _questions.Add(new Question2(_questions, _questionContext));
        _questions.Add(new Question3(_questions, _questionContext));
        _questions.Add(new Question4(_questions, _questionContext));
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        _questions[_questionContext.QuestionNumber].Show();

        _questionContext.QuestionNumber++;

        Hide();
    }
}