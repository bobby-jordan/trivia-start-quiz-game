using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaStarQuizGame.Models
{
    public class Question
    {
        public string Text { get; set; } 
        public string Category { get; set; } 
        public string QuestionImage { get; set; } 
        public List<Answer> Answers { get; set; } 
    }
}
