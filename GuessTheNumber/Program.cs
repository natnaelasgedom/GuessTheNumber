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
                remaining /= 2;
                Console.WriteLine("Is the number {0}", options + ", h or l?");
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
    }
}
