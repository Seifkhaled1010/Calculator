using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            decimal result = 0;
            int answer;

            Console.WriteLine("Hello! welcome to my calculator program!");

            Console.WriteLine("Please choose your operation: ");
            Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division.");
            answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the first number: ");
            num1 = Convert.ToDecimal (Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if (answer == 1)
                result = num1 + num2;
            else if (answer == 2)
                result = num1 - num2;
            else if (answer == 3)
                result = num1 * num2;
            else if (answer == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Can't divide by zero!");
                    return;
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else
                Console.WriteLine("Wrong operation!");

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using my program, please send your rate:)");

            Console.ReadKey();
        }
    }
}
