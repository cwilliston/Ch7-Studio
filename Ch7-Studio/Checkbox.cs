using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Studio
{
    public class Checkbox : Question
    {
        public string[] AnswerOptions { get; set; }

        public Checkbox(string[] answerOptions, string question, string answer) : base(question, answer)
        {
            AnswerOptions = answerOptions;
        }

        public void AssignNumberToAnswers()
        {
            for (int i = 0; i < AnswerOptions.Length; i++)
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

        //needs to be graded differently to account for multiple answers.. somehow
    }
}
