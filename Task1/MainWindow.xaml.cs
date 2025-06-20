using System.Windows;
using System.Windows.Controls;

namespace Task1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<Book> Library;
    private Book? currentBook;
    public MainWindow()
    {
        InitializeComponent();

        Library =
        [
            new()
            {
                Title = "Война и мир",
                Author = "Лев Толстой",
                Year = 1869,
                Genre = "Роман-эпопея"
            },
            new()
            {
                Title = "1984",
                Author = "Джордж Оруэлл",
                Year = 1949,
                Genre = "Антиутопия"
            },
            new()
            {
                Title = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1966,
                Genre = "Фантастика, Сатира"
            },
            new()
            {
                Title = "Преступление и наказание",
                Author = "Фёдор Достоевский",
                Year = 1866,
                Genre = "Психологический роман"
            },
            new()
            {
                Title = "Гарри Поттер и философский камень",
                Author = "Джоан Роулинг",
                Year = 1997,
                Genre = "Фэнтези"
            }
        ];

        libraryDataGrid.ItemsSource = Library;
    }

    private void LibraryDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (libraryDataGrid.SelectedItem is not null)
        {
            currentBook = (Book)libraryDataGrid.SelectedItem;

            titleTextBox.Text = currentBook.Title;
            authorTextBox.Text = currentBook.Author;
            yearTextBox.Text = currentBook.Year.ToString();
            genreTextBox.Text = currentBook.Genre;

            editButton.IsEnabled = true;
            deleteButton.IsEnabled = true;
            addButton.IsEnabled = false;
        }
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (int.TryParse(yearTextBox.Text, out var year))
            {
                var book = new Book()
                {
                    Title = titleTextBox.Text,
                    Author = authorTextBox.Text,
                    Year = year,
                    Genre = genreTextBox.Text
                };

                Library.Add(book);

                RefreshLibrary(Library);
            }
            else
            {
                MessageBox.Show("Некорректные данные в графе \"Год издания:\"");

                return;
            }
        }
        catch (System.FormatException)
        {
            MessageBox.Show("Все поля должны быть заполнены!");

            RefreshLibrary(Library);
        }
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        if (currentBook is not null)
        {
            Library.Remove(currentBook);

            RefreshLibrary(Library);

            editButton.IsEnabled = false;
            deleteButton.IsEnabled = false;
            addButton.IsEnabled = true;
        }
    }

    private void EditButton_Click(object sender, RoutedEventArgs e)
    {
        if (currentBook is not null)
        {
            currentBook.Title = titleTextBox.Text;
            currentBook.Author = authorTextBox.Text;
            currentBook.Year = int.Parse(yearTextBox.Text);
            currentBook.Genre = genreTextBox.Text;

            RefreshLibrary(Library);

            editButton.IsEnabled = false;
            deleteButton.IsEnabled = false;
            addButton.IsEnabled = true;
        }
    }

    private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        libraryDataGrid.SelectedItem = null;

        editButton.IsEnabled = false;
        deleteButton.IsEnabled = false;
        addButton.IsEnabled = true;

        RefreshLibrary(Library);
    }

    private void RefreshLibrary(List<Book> library)
    {
        titleTextBox.Text = string.Empty;
        authorTextBox.Text = string.Empty;
        yearTextBox.Text = string.Empty;
        genreTextBox.Text = string.Empty;

        libraryDataGrid.ItemsSource = null;
        libraryDataGrid.ItemsSource = library;
    }
}