using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        private Color buttonBackgroundColor = Color.FromArgb("#F4A261");

        public Color ButtonBackgroundColor
        {
            get => buttonBackgroundColor;
            set
            {
                buttonBackgroundColor = value;
                OnPropertyChanged();
            }
        }


        public ICommand ContinueCommand { get; }
        public ICommand PointerEnteredCommand { get; }
        public ICommand PointerExitedCommand { get; }

        public GameStartViewModel()
        {
            ContinueCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(PlayerName))
                {
                    await Shell.Current.GoToAsync(nameof(SelectCategoryPage));
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Please enter your name", "OK");
                }
            });
        }
    }
}
