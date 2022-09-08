using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Studio
{
    public class TrueFalse : Question
    {
        public TrueFalse(string question, string answer) : base(question, answer)
        {
        }

        public override void GradeQuestion(string userAnswer)
        {
            userAnswer = userAnswer.ToLower();
            if (userAnswer != "true" || userAnswer != "false") {
                Console.WriteLine("Please enter true or false.");
                return;
            }
            
            base.GradeQuestion(userAnswer);
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"True or False: {QuestionText}");
        }
    }
}
