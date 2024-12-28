using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriviaStarQuizGame.Enums;
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

        public List<Answer> Answers
        {
            get => answers;
            set => SetProperty(ref answers, value);
        }

        public bool IsSubmitEnabled => Answers?.Any(a => a.IsSelected) ?? false;

        public Command<Answer> SelectAnswerCommand { get; }
        public Command SubmitAnswerCommand { get; }

        public QuestionViewModel()
        {
            _questionProvider = new QuestionProvider();

            questions = _questionProvider.GetQuestions(CurrentCategory);

            LoadQuestion();

            SelectAnswerCommand = new Command<Answer>(selectedAnswer =>
            {
                foreach (var answer in Answers)
                {
                    answer.IsSelected = answer == selectedAnswer;
                }

                // Notify UI about changes
                OnPropertyChanged(nameof(Answers));
                OnPropertyChanged(nameof(IsSubmitEnabled));
            });

            SubmitAnswerCommand = new Command(async () =>
            {
                if (Answers.FirstOrDefault(a => a.IsSelected)?.IsCorrect ?? false)
                {
                    Score += 20; // Increment score
                }

                questionIndex++;

                if (questionIndex < questions.Count)
                {
                    LoadQuestion();
                }
                else
                {
                    await Shell.Current.GoToAsync($"//{nameof(FinalPage)}?score={Score}");
                }
            });
        }

        private void LoadQuestion()
        {
            var current = questions[questionIndex];
            CurrentQuestion = current.Text;

            Answers = current.Answers.Select(a => new Answer
            {
                Text = a.Text,
                IsCorrect = a.IsCorrect,
                IsSelected = false
            }).ToList();

            // Notify the UI
            OnPropertyChanged(nameof(CurrentQuestion));
            OnPropertyChanged(nameof(QuestionImage)); // Notify about image update
            OnPropertyChanged(nameof(Answers));
            OnPropertyChanged(nameof(IsSubmitEnabled));
        }
    }
}
