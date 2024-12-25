namespace TriviaStarQuizGame.ViewModels
{
    public class FinalViewModel : BaseViewModel
    {
        public int Score { get; }
        public Command PlayAgainCommand { get; }

        public FinalViewModel(int score)
        {
            Score = score;
            PlayAgainCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            });
        }
    }
}
