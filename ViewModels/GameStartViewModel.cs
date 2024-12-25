using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class GameStartViewModel : BaseViewModel
    {
        private string playerName = "Bobby";
        public string PlayerName
        {
            get => playerName;
            set => SetProperty(ref playerName, value);
        }

        public Command ContinueCommand { get; }

        public GameStartViewModel()
        {
            ContinueCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(PlayerName))
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new SelectCategoryPage(PlayerName));
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Please enter your name", "OK");
                }
            });
        }
    }
}
