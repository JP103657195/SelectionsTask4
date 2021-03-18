using System;

namespace SelectionsTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter another number: ");
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int total = num1 + num2;

            if (total >10)
            {
                Console.WriteLine("Sum of numbers is greater than 10.");
            }

            if (total <10)
            {
                Console.WriteLine("The sum of numbers is less than 10.");
            }

            if (total == 10)
            {
                Console.WriteLine("Sum of numbers is equal to 10.");
            }
            
        }
    }
}
