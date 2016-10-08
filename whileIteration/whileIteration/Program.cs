using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            while (displayMenu())
            {
                displayMenu();
            }
        }

        private static bool displayMenu()
        {
            Console.Clear();
            Console.WriteLine("1>. Play Guessing Game!");
            Console.WriteLine("2>. Exit");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                playgame();
                return true;
            }
            else if (a == 2){
                return false;
            }
            else
            {
                Console.WriteLine("You just got dumber!");
                return true;
            }

        }

        private static  void playgame()
        {
            Console.WriteLine("Guess a number::  ");
            
            Random randnum = new Random();
            int y = randnum.Next(1, 11);
            bool ans = false;
            do
            {
                Console.WriteLine("give me the number guessed! BETWEEN 1 and 10::::  ");
                int x = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    ans = true;
                }

            } while (ans == false);
            
        }
    }
}
