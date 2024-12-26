using TriviaStarQuizGame.Enums;
using TriviaStarQuizGame.ViewModels;

namespace TriviaStarQuizGame.Views;
[QueryProperty(nameof(Category), "category")]
public partial class QuestionPage : ContentPage
{
    private string category;

    public string Category
    {
        get => category;
        set
        {
            category = value;
            ((QuestionViewModel)BindingContext).CurrentCategory = Enum.Parse<QuizCategory>(category); // Set in ViewModel
        }
    }
    public QuestionPage()
    {
        InitializeComponent();
        BindingContext = new QuestionViewModel();
    }
}
