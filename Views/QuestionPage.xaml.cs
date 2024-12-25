namespace TriviaStarQuizGame.Views;

public partial class QuestionPage : ContentPage
{
    public QuestionPage(string category)
    {
        InitializeComponent();
        BindingContext = new ViewModels.QuestionViewModel(category);
    }
}