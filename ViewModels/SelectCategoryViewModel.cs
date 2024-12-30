using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriviaStarQuizGame.Enums;
using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class SelectCategoryViewModel : BaseViewModel
    {
        public List<string> Categories { get; } = Enum.GetNames(typeof(QuizCategory)).ToList();

        public Command<string> SelectCategoryCommand { get; }

        private string playerName;
        public string PlayerName
        {
            get => playerName;
            set => SetProperty(ref playerName, value);
        }


        public SelectCategoryViewModel()
        {
            SelectCategoryCommand = new Command<string>(async (category) =>
            {
                if (!string.IsNullOrEmpty(category))
                {
                    // Update CurrentCategory in the QuizState
                    State.CurrentCategory = Enum.Parse<QuizCategory>(category);

                    // Navigate to QuestionPage, passing both category and playerName
                    await Shell.Current.GoToAsync($"{nameof(QuestionPage)}?playerName={PlayerName}&category={category}");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Please select a category", "OK");
                }
            });
        }
    }
}
