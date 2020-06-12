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
            int options = 500;
            int remaining = 500;
            while (true)
            {
                remaining = remaining / 2;
                Console.WriteLine("Is the number {0}", options + "h or l?");
                string answer = Console.ReadLine();
                if (answer == "h")
                {
                    options += remaining;
                }
                else
                {
                    options -= remaining;
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
