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
            bool validInput = true;
            while (true)
            {
                Console.Clear();
                
                while (validInput)
                {
                    optionsLeft = optionsLeft / 2;
                    break;
                }

                validInput = true;
                Console.WriteLine("Is the number {0}?", guess + " Y, H or L?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "h")
                    guess += optionsLeft;
                else if (answer == "l")
                    guess -= optionsLeft;
                else if (answer == "y")
                    break;
                else
                {
                    Console.WriteLine("Please type a correct input. Press any key to try again");
                    Console.ReadKey();
                    validInput = false;
                }
            }
        }
    }
}
