using TriviaStarQuizGame.Enums;

namespace TriviaStarQuizGame.State
{
    public class QuizState
    {
        public static QuizState Instance { get; } = new QuizState();

        private QuizState() { Reset(); }

        public QuizCategory? CurrentCategory { get; set; } 
        public string PlayerName { get; set; }
        public int Score { get; set; }

        /// <summary>
        /// Resets the quiz state to its initial values.
        /// </summary>
        public void Reset()
        {
            CurrentCategory = null; 
            PlayerName = string.Empty;
            Score = 0;
        }
    }
}
