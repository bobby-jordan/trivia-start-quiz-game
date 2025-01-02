using System.Collections.ObjectModel;
using TriviaStarQuizGame.Models;
using TriviaStarQuizGame.Utilities;
using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class QuestionViewModel : BaseViewModel
    {
        private int questionIndex = 0;
        private string currentQuestion;
        private List<Answer> answers;
        private List<Question> questions;
        private readonly QuestionProvider _questionProvider;

        public string CurrentQuestion
        {
            get => currentQuestion;
            set => SetProperty(ref currentQuestion, value);
        }

        public string QuestionImage => questions[questionIndex]?.QuestionImage; // Bindable property for image

        public ObservableCollection<Answer> Answers { get; set; } = new ObservableCollection<Answer>();

        public bool IsSubmitEnabled => Answers?.Any(a => a.IsSelected) ?? false;

        public Command<Answer> SelectAnswerCommand { get; }
        public Command SubmitAnswerCommand { get; }

        public QuestionViewModel()
        {
            _questionProvider = new QuestionProvider();

            questions = _questionProvider.GetQuestions(CurrentCategory);

            LoadQuestion();

            SelectAnswerCommand = new Command<Answer>(async (selectedAnswer) =>
            {
                foreach (var answer in Answers)
                {
                    answer.IsSelected = answer == selectedAnswer;
                    Console.WriteLine($"{answer.Text}: IsSelected = {answer.IsSelected}");
                }

                OnPropertyChanged(nameof(Answers));
                OnPropertyChanged(nameof(IsSubmitEnabled));

                if (selectedAnswer != null)
                {
                    if (selectedAnswer.IsCorrect)
                    {
                        Score += 20; 
                    }

                    await Task.Delay(1000); 

                    questionIndex++;

                    if (questionIndex < questions.Count)
                    {
                        LoadQuestion();
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(FinalPage)}?score={Score}");
                    }
                }
            });

        }

        private void LoadQuestion()
        {
            var current = questions[questionIndex];
            CurrentQuestion = current.Text;

            Answers.Clear(); 

            foreach (var answer in current.Answers)
            {
                Answers.Add(new Answer
                {
                    Text = answer.Text,
                    IsCorrect = answer.IsCorrect,
                    IsSelected = false
                });
            }

            OnPropertyChanged(nameof(CurrentQuestion));
            OnPropertyChanged(nameof(QuestionImage)); 
            OnPropertyChanged(nameof(Answers));
            OnPropertyChanged(nameof(IsSubmitEnabled));
        }
    }
}
