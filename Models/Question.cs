using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaStarQuizGame.Models
{
    public class Question
    {
        public string Text { get; set; } // The question text
        public string Category { get; set; } // The category of the question
        public List<Answer> Answers { get; set; } // The list of answers
    }
}
