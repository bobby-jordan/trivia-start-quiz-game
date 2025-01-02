using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class FinalViewModel : BaseViewModel
    {
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
