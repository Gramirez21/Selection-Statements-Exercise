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

        }

    }
}
