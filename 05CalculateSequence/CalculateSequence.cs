using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateSequence
{
    static void Main()
    {
       //S = 1 + 1!/ x + 2!/ x2 + … +n!/ xn

        Console.Write("Enter a namber, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a namber, x = ");
        int x = int.Parse(Console.ReadLine());

        double s = 1;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            s += i*factorial / Math.Pow(x, i);
            factorial *= i;
        }
            Console.WriteLine("sum = {0:F5}",s);
    }
}

