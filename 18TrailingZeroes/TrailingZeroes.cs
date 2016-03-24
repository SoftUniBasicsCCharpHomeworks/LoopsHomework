using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main()
        {
            Console.Write("Enter a positive number n: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            int trailingZeroes = 0;
            int sum = 5; 

            while (n >= sum)
            {
                trailingZeroes += (n / sum);
                sum *= 5;
            }
            Console.WriteLine("trailing zeroes in {0}! are {1}", n, trailingZeroes);
        }
    }
}
