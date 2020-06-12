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
        public void Menu()
		{
            bool playing = true;
            while (playing)
            {
                Console.Clear();
                Console.WriteLine("**********GUESS A NUMBER***********");

                Console.WriteLine("\n1. Play Guess A Number!");
                Console.WriteLine("2. Tables Have Turned! You guess the secret digitz!");
                Console.WriteLine("3. Exitz");

                bool isInt = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int input);

                switch (input)
                {
                    case (1):
                        //run the game
                        break;
                    case (2):
                        //run teh opposite game
                        break;
                    case (3):
                        {
                            playing = false;
                            break;
                        }
                    default:
                        break;
                }
            }
		}
    }
}
