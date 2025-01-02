using TriviaStarQuizGame.ViewModels;

namespace TriviaStarQuizGame.Views;
public partial class QuestionPage : ContentPage
{
    public QuestionPage()
    {
        InitializeComponent();
        BindingContext = new QuestionViewModel();
    }
}
