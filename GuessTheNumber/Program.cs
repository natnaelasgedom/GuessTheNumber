using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Randoms();
            random.Run();
        }
    }
    class Randoms
    {
        public void Run()
        {
            int guess = 500;
            int optionsLeft = 500;
            bool correct = false;
            while (!correct)
            {
                optionsLeft = optionsLeft / 2;
                Console.WriteLine("Is the number {0}?", guess + " yes, higher or lower?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "higher")
                {
                    guess += optionsLeft;
                }
                else if (answer == "lower")
                {
                    guess -= optionsLeft;
                }
                else if (answer == "yes")
                {
                    correct = true;
                }
            }
        }
    }
}
