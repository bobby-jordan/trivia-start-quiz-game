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

        public SelectCategoryViewModel()
        {
            SelectCategoryCommand = new Command<string>(async (selectedCategory) =>
            {
                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    CurrentCategory = Enum.Parse<QuizCategory>(selectedCategory); // Set the global property
                    await Shell.Current.GoToAsync($"//{nameof(QuestionPage)}?category={CurrentCategory}");
                }
            });
        }
    }
}
