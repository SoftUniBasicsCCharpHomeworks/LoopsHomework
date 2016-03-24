using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter a positive number n: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            

            BigInteger factorial = 1;

            for (BigInteger i = 1; i <= n ; i++)
            {
                factorial *= i;
            }

            BigInteger difference = 1;

            for (BigInteger i = n + 2; i <= 2 * n; i++)
            {
                difference *= i;
            }

            Console.WriteLine("(2*n)! / (n+1)!*n!= {0}", difference / factorial);
        }
    }
}
