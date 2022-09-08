using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Studio
{
    public class MultipleChoice : Question
    {
        public List<string> AnswerOptions { get; set; }

        public MultipleChoice(List<string> answerOptions, string question, string answer) : base(question, answer)
        {
            AnswerOptions = answerOptions;
            this.AssignNumberToAnswers();
        }

        public void AssignNumberToAnswers()
        {
            for (int i = 0; i < AnswerOptions.Count; i++)
            {
                AnswerOptions[i] = $"{(i + 1)}: {AnswerOptions[i]}";
            }
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine(this.QuestionText);
            foreach (var answer in AnswerOptions)
            {
                Console.WriteLine("\n" + answer);
            }
        }

        public override void GradeQuestion(string userAnswer)
        {
            if(Int32.Parse(userAnswer) > AnswerOptions.Count || Int32.Parse(userAnswer) < 1)
            {
                Console.WriteLine("Invalid Answer. Please Select one of the numbered answers.");
            }

            base.GradeQuestion(userAnswer);
        }
    }
}
