using Microsoft.Maui.Controls;

using TriviaStarQuizGame.ViewModels;

namespace TriviaStarQuizGame.Views
{
    public partial class SelectCategoryPage : ContentPage
    {
        public SelectCategoryPage()
        {
            InitializeComponent();
            BindingContext = new SelectCategoryViewModel();
        }
    }
}
