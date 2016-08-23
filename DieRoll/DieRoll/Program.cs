using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Die Roll";
            Console.WriteLine("Ready to roll the dice?");
            Console.WriteLine("\nPress enter to roll \nPress \"Q\" to quit.\n");

            bool pressedEnter = true;
            Random rand = new Random();

            //Using switch statement makes pressing "Q" instantly responsive.
            while (pressedEnter)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Enter:
                        int roll = rand.Next(1, 7);
                        Console.Write("{0} {1}", "You rolled : ", roll);
                        Console.SetCursorPosition(0, Console.CursorTop);
                        pressedEnter = true;
                        break;

                    case ConsoleKey.Q:
                        pressedEnter = false;
                        break;
                }
                /*if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(rand.Next(1, 7));
                    pressedEnter = true;
                }
                    
                else if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    pressedEnter = false;
                }*/
            }
            Console.WriteLine("\nThanks for playing.");
            Console.ReadLine();
        }
    }
}
