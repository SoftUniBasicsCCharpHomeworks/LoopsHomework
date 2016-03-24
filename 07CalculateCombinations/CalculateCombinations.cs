using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            //calculate n! / (k! * (n-k)!) 

            Console.Write("Enter a positive number n: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter a positive number k (k<n): ");
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (BigInteger i = k + 1; i <= n; i++)
            {
                factorial *= i;
            }

            BigInteger diffrence = 1;

            for (BigInteger i = 1; i <= n-k; i++)
            {
                diffrence *= i;
            }
            Console.WriteLine("n! / k!*(n-k)!= {0}", factorial / diffrence);
        }
    }
}
