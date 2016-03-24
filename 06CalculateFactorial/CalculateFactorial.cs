using System;
using System.Numerics;


class CalculateFactorial
{
    static void Main()
    {
        //Calculate N! / K!

        Console.Write("Enter a positive number n: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter a positive number k (k<n): ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (BigInteger i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("{0}!/{1}!= {2}", n, k, factorial);
    }
}

