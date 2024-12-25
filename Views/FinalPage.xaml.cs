namespace TriviaStarQuizGame.Views;

public partial class FinalPage : ContentPage
{
    public FinalPage(int score)
    {
        InitializeComponent();
        BindingContext = new ViewModels.FinalViewModel(score);
    }
}