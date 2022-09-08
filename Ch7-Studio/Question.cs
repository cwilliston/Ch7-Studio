using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Studio
{
    public abstract class Question
    {
        public string Answer { get; set; }
        public string QuestionText { get; set; }

        public int Score { get; set; } = 0;

        public Question(string question, string answer)
        {
            QuestionText = question;
            Answer = answer;
        }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);

        }

        public void DisplayAnswer()
        {
            Console.WriteLine(Answer);
        }


        public virtual void GradeQuestion(string userAnswer)
        {
            if (userAnswer == Answer)
            {
                this.Score++;
            }

            Console.WriteLine($"Your score is {Score}");
        }
    }
}
