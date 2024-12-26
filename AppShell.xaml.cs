using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register routes for navigation
            Routing.RegisterRoute(nameof(GameStartPage), typeof(GameStartPage));
            Routing.RegisterRoute(nameof(SelectCategoryPage), typeof(SelectCategoryPage));
            Routing.RegisterRoute(nameof(QuestionPage), typeof(QuestionPage));
            Routing.RegisterRoute(nameof(FinalPage), typeof(FinalPage));
        }
    }
}
