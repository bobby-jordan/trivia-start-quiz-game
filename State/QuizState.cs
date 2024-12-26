using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriviaStarQuizGame.Enums;

namespace TriviaStarQuizGame.State
{
    public class QuizState
    {
        public static QuizState Instance { get; } = new QuizState();

        private QuizState() { }

        public QuizCategory CurrentCategory { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
    }
}
