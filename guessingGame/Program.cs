using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomGameNumber = rnd.Next(1, 100);
            int guessNum = -1;
            int turn = 1;
            while (randomGameNumber != guessNum)
            {
                Console.WriteLine("Gues a number from 1 to 100: ");
                guessNum = Convert.ToInt32(Console.ReadLine());
                if (randomGameNumber == guessNum)
                {
                    Console.WriteLine($"You guessed correctly in {turn} tries");
                }
                else
                {
                    if (randomGameNumber < guessNum)
                    {
                        Console.WriteLine("You guessed too high");
                    }
                    else
                    {
                        Console.WriteLine("You guessed too low");
                    }
                }
                turn++;                    
            }            
            Thread.Sleep(10000);
        }
    }
}
