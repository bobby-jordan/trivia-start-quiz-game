using TriviaStarQuizGame.ViewModels;

namespace TriviaStarQuizGame.Views;

public partial class FinalPage : ContentPage
{
    public FinalPage()
    {
        InitializeComponent();
        BindingContext = new FinalViewModel();
    }
}