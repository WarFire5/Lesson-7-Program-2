using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B;

            Console.WriteLine("Задайте число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Задайте число 'B':");
            B = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int addition = a + b;

            int multiplication = a * b;

            int subtraction = a - b;

            if (a > b)
            {
                Console.WriteLine(addition);
            }

            if (a == b)
            {
                Console.WriteLine(multiplication);
            }

            if (a < b)
            {
                Console.WriteLine(subtraction);
            }
            
            Console.ReadLine();
        }
    }
}
