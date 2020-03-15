using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework1
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
