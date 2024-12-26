using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class FinalViewModel : BaseViewModel
    {
        public string FinalScore => $"Your Score: {Score}";
        public Command PlayAgainCommand { get; }

        public FinalViewModel()
        {
            PlayAgainCommand = new Command(async () =>
            {
                // Navigate back to the GameStartPage
                await Shell.Current.GoToAsync($"//{nameof(GameStartPage)}");
            });
        }
    }
}
