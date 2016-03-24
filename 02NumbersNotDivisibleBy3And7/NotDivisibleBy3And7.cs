using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDivisibleBy3And7
{
    class NotDivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (!((i % 3 == 0) || (i % 7 == 0)))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
