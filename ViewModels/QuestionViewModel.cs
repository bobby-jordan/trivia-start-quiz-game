using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriviaStarQuizGame.Enums;
using TriviaStarQuizGame.Models;
using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame.ViewModels
{
    public class QuestionViewModel : BaseViewModel
    {
        private int questionIndex = 0;
        private string currentQuestion;
        private List<Answer> answers;
        private List<Question> questions;

        public string CurrentQuestion
        {
            get => currentQuestion;
            set => SetProperty(ref currentQuestion, value);
        }

        public List<Answer> Answers
        {
            get => answers;
            set => SetProperty(ref answers, value);
        }

        public bool IsSubmitEnabled
        {
            get => Answers?.Any(a => a.IsSelected) ?? false;
        }

        public Command<Answer> SelectAnswerCommand { get; }
        public Command SubmitAnswerCommand { get; }

        public QuestionViewModel()
        {
            questions = GetQuestions(CurrentCategory); // Use the persisted category

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
                    Score++; // Increment score
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

            // Reset answers with their initial states
            Answers = current.Answers.Select(a => new Answer
            {
                Text = a.Text,
                IsCorrect = a.IsCorrect,
                IsSelected = false
            }).ToList();

            OnPropertyChanged(nameof(Answers));
            OnPropertyChanged(nameof(IsSubmitEnabled));
        }

        private List<Question> GetQuestions(QuizCategory category)
        {
            return category switch
            {
                QuizCategory.Science => new List<Question>
        {
            new Question
            {
                Text = "What is the chemical symbol for water?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "H2O", IsCorrect = true },
                    new Answer { Text = "O2", IsCorrect = false },
                    new Answer { Text = "CO2", IsCorrect = false },
                    new Answer { Text = "NaCl", IsCorrect = false }
                }
            },
            // Add 4 more Science questions here
        },

                QuizCategory.Art => new List<Question>
        {
            new Question
            {
                Text = "Who painted the Mona Lisa?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Leonardo da Vinci", IsCorrect = true },
                    new Answer { Text = "Pablo Picasso", IsCorrect = false },
                    new Answer { Text = "Vincent van Gogh", IsCorrect = false },
                    new Answer { Text = "Claude Monet", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What art movement is Salvador Dalí associated with?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Surrealism", IsCorrect = true },
                    new Answer { Text = "Cubism", IsCorrect = false },
                    new Answer { Text = "Impressionism", IsCorrect = false },
                    new Answer { Text = "Realism", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "The Starry Night was painted by which artist?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Vincent van Gogh", IsCorrect = true },
                    new Answer { Text = "Claude Monet", IsCorrect = false },
                    new Answer { Text = "Edgar Degas", IsCorrect = false },
                    new Answer { Text = "Paul Cézanne", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which famous sculpture was created by Michelangelo?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "David", IsCorrect = true },
                    new Answer { Text = "The Thinker", IsCorrect = false },
                    new Answer { Text = "Venus de Milo", IsCorrect = false },
                    new Answer { Text = "Apollo Belvedere", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What is the art technique of using light and shadow to create depth?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Chiaroscuro", IsCorrect = true },
                    new Answer { Text = "Fresco", IsCorrect = false },
                    new Answer { Text = "Pointillism", IsCorrect = false },
                    new Answer { Text = "Sfumato", IsCorrect = false }
                }
            }
        },
                QuizCategory.Culture => new List<Question>
        {
            new Question
            {
                Text = "What is the traditional dress of Japan called?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Kimono", IsCorrect = true },
                    new Answer { Text = "Hanbok", IsCorrect = false },
                    new Answer { Text = "Sari", IsCorrect = false },
                    new Answer { Text = "Cheongsam", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which country is famous for its flamenco dance?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Spain", IsCorrect = true },
                    new Answer { Text = "France", IsCorrect = false },
                    new Answer { Text = "Italy", IsCorrect = false },
                    new Answer { Text = "Portugal", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Diwali is a festival celebrated in which country?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "India", IsCorrect = true },
                    new Answer { Text = "Nepal", IsCorrect = false },
                    new Answer { Text = "Sri Lanka", IsCorrect = false },
                    new Answer { Text = "Bangladesh", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What is the name of the Maori traditional dance?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Haka", IsCorrect = true },
                    new Answer { Text = "Samba", IsCorrect = false },
                    new Answer { Text = "Tango", IsCorrect = false },
                    new Answer { Text = "Limbo", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which African country is known for its Maasai tribe?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Kenya", IsCorrect = true },
                    new Answer { Text = "South Africa", IsCorrect = false },
                    new Answer { Text = "Nigeria", IsCorrect = false },
                    new Answer { Text = "Ethiopia", IsCorrect = false }
                }
            }
        },
                QuizCategory.Technology => new List<Question>
        {
            new Question
            {
                Text = "Who is known as the father of computers?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Charles Babbage", IsCorrect = true },
                    new Answer { Text = "Alan Turing", IsCorrect = false },
                    new Answer { Text = "John von Neumann", IsCorrect = false },
                    new Answer { Text = "Steve Jobs", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What does CPU stand for?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Central Processing Unit", IsCorrect = true },
                    new Answer { Text = "Computer Processing Unit", IsCorrect = false },
                    new Answer { Text = "Central Programming Unit", IsCorrect = false },
                    new Answer { Text = "Core Processing Unit", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which company developed the Windows operating system?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Microsoft", IsCorrect = true },
                    new Answer { Text = "Apple", IsCorrect = false },
                    new Answer { Text = "IBM", IsCorrect = false },
                    new Answer { Text = "Google", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What programming language is primarily used for Android app development?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Java", IsCorrect = true },
                    new Answer { Text = "Swift", IsCorrect = false },
                    new Answer { Text = "Python", IsCorrect = false },
                    new Answer { Text = "C#", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which technology is used to connect devices wirelessly over short distances?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Bluetooth", IsCorrect = true },
                    new Answer { Text = "Wi-Fi", IsCorrect = false },
                    new Answer { Text = "NFC", IsCorrect = false },
                    new Answer { Text = "Infrared", IsCorrect = false }
                }
            }
        },
                QuizCategory.Entertainment => new List<Question>
        {
            new Question
            {
                Text = "Who played Jack in the movie Titanic?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Leonardo DiCaprio", IsCorrect = true },
                    new Answer { Text = "Brad Pitt", IsCorrect = false },
                    new Answer { Text = "Tom Cruise", IsCorrect = false },
                    new Answer { Text = "Johnny Depp", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What is the highest-grossing movie of all time?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Avatar", IsCorrect = true },
                    new Answer { Text = "Avengers: Endgame", IsCorrect = false },
                    new Answer { Text = "Titanic", IsCorrect = false },
                    new Answer { Text = "The Lion King", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Who sang 'Shape of You'?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Ed Sheeran", IsCorrect = true },
                    new Answer { Text = "Shawn Mendes", IsCorrect = false },
                    new Answer { Text = "Justin Bieber", IsCorrect = false },
                    new Answer { Text = "Sam Smith", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What year was the first Harry Potter movie released?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "2001", IsCorrect = true },
                    new Answer { Text = "2000", IsCorrect = false },
                    new Answer { Text = "2002", IsCorrect = false },
                    new Answer { Text = "1999", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What is the name of the coffee shop in Friends?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Central Perk", IsCorrect = true },
                    new Answer { Text = "Coffee Haven", IsCorrect = false },
                    new Answer { Text = "Cafe Central", IsCorrect = false },
                    new Answer { Text = "Friends Cafe", IsCorrect = false }
                }
            }
        },
                QuizCategory.History => new List<Question>
        {
            new Question
            {
                Text = "Who was the first President of the United States?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "George Washington", IsCorrect = true },
                    new Answer { Text = "Abraham Lincoln", IsCorrect = false },
                    new Answer { Text = "Thomas Jefferson", IsCorrect = false },
                    new Answer { Text = "John Adams", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which war ended in 1945?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "World War II", IsCorrect = true },
                    new Answer { Text = "World War I", IsCorrect = false },
                    new Answer { Text = "Cold War", IsCorrect = false },
                    new Answer { Text = "Vietnam War", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Who discovered America?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Christopher Columbus", IsCorrect = true },
                    new Answer { Text = "Amerigo Vespucci", IsCorrect = false },
                    new Answer { Text = "Leif Erikson", IsCorrect = false },
                    new Answer { Text = "James Cook", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "When was the Declaration of Independence signed?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "1776", IsCorrect = true },
                    new Answer { Text = "1783", IsCorrect = false },
                    new Answer { Text = "1801", IsCorrect = false },
                    new Answer { Text = "1754", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What empire did Genghis Khan rule?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Mongol Empire", IsCorrect = true },
                    new Answer { Text = "Ottoman Empire", IsCorrect = false },
                    new Answer { Text = "Roman Empire", IsCorrect = false },
                    new Answer { Text = "British Empire", IsCorrect = false }
                }
            }
        },
                QuizCategory.Politics => new List<Question>
        {
            new Question
            {
                Text = "Who is known as the Father of the Constitution?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "James Madison", IsCorrect = true },
                    new Answer { Text = "Alexander Hamilton", IsCorrect = false },
                    new Answer { Text = "Thomas Jefferson", IsCorrect = false },
                    new Answer { Text = "George Washington", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What political system is ruled by a king or queen?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Monarchy", IsCorrect = true },
                    new Answer { Text = "Democracy", IsCorrect = false },
                    new Answer { Text = "Communism", IsCorrect = false },
                    new Answer { Text = "Socialism", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Who was the first female Prime Minister of the UK?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Margaret Thatcher", IsCorrect = true },
                    new Answer { Text = "Theresa May", IsCorrect = false },
                    new Answer { Text = "Angela Merkel", IsCorrect = false },
                    new Answer { Text = "Indira Gandhi", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What year did the United Nations form?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "1945", IsCorrect = true },
                    new Answer { Text = "1919", IsCorrect = false },
                    new Answer { Text = "1939", IsCorrect = false },
                    new Answer { Text = "1950", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which country has the largest democracy?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "India", IsCorrect = true },
                    new Answer { Text = "United States", IsCorrect = false },
                    new Answer { Text = "Brazil", IsCorrect = false },
                    new Answer { Text = "Australia", IsCorrect = false }
                }
            }
        },
                QuizCategory.Geography => new List<Question>
        {
            new Question
            {
                Text = "What is the largest country in the world?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Russia", IsCorrect = true },
                    new Answer { Text = "Canada", IsCorrect = false },
                    new Answer { Text = "China", IsCorrect = false },
                    new Answer { Text = "United States", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Which river is the longest in the world?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Nile", IsCorrect = true },
                    new Answer { Text = "Amazon", IsCorrect = false },
                    new Answer { Text = "Yangtze", IsCorrect = false },
                    new Answer { Text = "Mississippi", IsCorrect = false }
                }
            },
            // Add 3 more questions
        },
                QuizCategory.Sport => new List<Question>
        {
            new Question
            {
                Text = "What sport is known as 'The Beautiful Game'?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Football (Soccer)", IsCorrect = true },
                    new Answer { Text = "Basketball", IsCorrect = false },
                    new Answer { Text = "Tennis", IsCorrect = false },
                    new Answer { Text = "Cricket", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "What is the national sport of Japan?",
                Category = category.ToString(),
                Answers = new List<Answer>
                {
                    new Answer { Text = "Sumo Wrestling", IsCorrect = true },
                    new Answer { Text = "Baseball", IsCorrect = false },
                    new Answer { Text = "Judo", IsCorrect = false },
                    new Answer { Text = "Karate", IsCorrect = false }
                }
            },
            // Add 3 more questions
        },
                _ => new List<Question>()
            };
        }


    }
}
