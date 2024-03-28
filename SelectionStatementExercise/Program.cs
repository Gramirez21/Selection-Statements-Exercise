using System;

namespace SelectionStatements
{
    internal class program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var yourfavenumber = r.Next(0, 1001);
            int userInput;
            do
            {
                Console.WriteLine("Guess my favorite number between 1 and 1000:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > yourfavenumber)
                {
                    Console.WriteLine($"sorry too high");
                }
                else if (userInput < yourfavenumber)
                {
                    Console.WriteLine($"sorry too low");
                }
                else
                {
                    Console.WriteLine($"congrats youre right");
                }
            } while (userInput != yourfavenumber);

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("i love math");
                    break;
                case "science":
                    Console.WriteLine("i hate math");
                    break;
                case "p.e":
                    Console.WriteLine("p.e is okay i guess");
                    break;
                case "History":
                    Console.WriteLine("history is fun");
                    break;
                case "Calculus":
                    Console.WriteLine("well damn your smart");
                    break;
                default:
                    Console.WriteLine("I dont know that subject");
                    break;
            }
        }

    }
}
