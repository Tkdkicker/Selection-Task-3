using System;

namespace Selection___Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Well done");
                    break;
                case 'C':
                    Console.WriteLine("You passed");
                    break;
                case 'D':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is " + grade);
            Console.ReadLine();
        }
    }
}
