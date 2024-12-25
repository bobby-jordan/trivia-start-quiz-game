namespace TriviaStarQuizGame.Views;
public partial class SelectCategoryPage : ContentPage
{
    public SelectCategoryPage(string playerName)
    {
        InitializeComponent();
        BindingContext = new ViewModels.SelectCategoryViewModel(playerName);
    }
}