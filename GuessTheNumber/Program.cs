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
            double guess = 500;
            double optionsLeft = 500;
            bool validInput = true;
            while (true)
            {
                Console.Clear();
                
                while (validInput)
                {
                    optionsLeft /= 2;
                    break;
                }

                validInput = true;
                Console.WriteLine("Is the number {0}?", guess);
				Console.WriteLine("Choose: (H)igher or (L)ower (Y)es?");
                string answer = Console.ReadLine().ToLower();

				switch (answer)
				{
                    case ("h"):
                        guess = Math.Round(guess + optionsLeft);
                        break;
                    case ("l"):
                        guess = Math.Round(guess - optionsLeft);
                        break;
                    case ("y"):
                        Console.WriteLine("CORRECT!!");
                        Console.ReadKey();
                        break;
					default:
                        Console.WriteLine("Please type a correct input. Press any key to try again");
                        Console.ReadKey();
                        validInput = false;
						break;
				}
                /*
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
                }*/
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
