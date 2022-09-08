namespace Ch7_Studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amanda and Carolynn's Quiz:\n");

            List<string> bestPetAnswers = new List<string> { "Dogs", "Cats", "Rabbits", "Reptiles" };
            MultipleChoice bestPet = new MultipleChoice( bestPetAnswers, "What is the best pet to own?", "B");
            bestPet.DisplayQuestion();
            bestPet.GradeQuestion(Console.ReadLine());
            bestPet.DisplayAnswer();

            TrueFalse codingIsFun = new TrueFalse("Coding is fun.", "true");
            codingIsFun.DisplayQuestion();
            codingIsFun.GradeQuestion(Console.ReadLine());
            codingIsFun.DisplayAnswer();
        }
    }
}