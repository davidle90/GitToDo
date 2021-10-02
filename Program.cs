using System;
using static System.Console;
using System.Threading;

namespace GitTODO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;            //Run application while true

            while (running)
            {
                Clear();
                WriteLine("====")
                WriteLine("\tMain Menu");
                WriteLine("\t[1]Add Product");
                WriteLine("\t[2]Search Product");
                WriteLine("\t[3]Show All Products");
                WriteLine("\t[4]Exit");

                var input = ReadKey();

                switch (input.Key)
                {

                    case ConsoleKey.D1:              //Menu 1: Add Product
                    case ConsoleKey.NumPad1:

                        WriteLine("Hello World");
                        ReadKey();
                        break;

                    case ConsoleKey.D2:             //Menu 2: Search Product
                    case ConsoleKey.NumPad2:

                        WriteLine("Goodbye WOrld");
                        ReadKey();
                        break;

                    case ConsoleKey.D3:              //Menu 3: Show All Products
                    case ConsoleKey.NumPad3:

                        WriteLine("ok world");
                        ReadKey();
                        break;

                    case ConsoleKey.D4:              //Menu 3: Exit
                    case ConsoleKey.NumPad4:

                        Clear();
                        WriteLine("Closing application..");
                        Thread.Sleep(1000);
                        running = false;
                        break;

                    default:                        //Nothing happens on invalid input
                        break;
                }
            }

        }
    }
}
