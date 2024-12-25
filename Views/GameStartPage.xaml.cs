namespace TriviaStarQuizGame.Views;

public partial class GameStartPage : ContentPage
{
    public GameStartPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.GameStartViewModel();
    }
}