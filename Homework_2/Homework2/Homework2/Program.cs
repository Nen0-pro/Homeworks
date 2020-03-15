using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework 2

            // Task 1

            //string firstName = "Nenad";
            //string lastName = "Popovski";

            //string fullName = firstName + " " + lastName;

            //Console.WriteLine(fullName);
            //Console.ReadLine();

            //string numberOne = "9";
            //string numberTwo = "3";

            //string result = numberOne + " " + numberTwo;

            //Console.WriteLine(result);
            //Console.ReadLine();

            //// Task 2

            //string name = "Nenad";

            //int num = 10;

            //var res = name + num;

            //Console.WriteLine(res);
            //Console.ReadLine();

            //// Task 3

            //int n = 102;

            //int m = 5;

            //int sms = n / m;

            //Console.WriteLine(sms);
            //Console.ReadLine();

            // Task 4

            Console.WriteLine("Enter number");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else if(input % 2 !=0)
            {
                Console.WriteLine("Odd number");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
