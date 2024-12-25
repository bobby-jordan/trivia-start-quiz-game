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
        public string PlayerName { get; }
        public List<string> Categories { get; } = Enum.GetNames(typeof(QuizCategory)).ToList();

        public Command<string> SelectCategoryCommand { get; }

        public SelectCategoryViewModel(string playerName)
        {
            PlayerName = playerName;
            SelectCategoryCommand = new Command<string>(async (category) =>
            {
                Console.WriteLine($"Selected Category: {category}");

                // Handle category selection
                await Application.Current.MainPage.Navigation.PushAsync(new Views.QuestionPage(category));

            });
        }
    }
}
