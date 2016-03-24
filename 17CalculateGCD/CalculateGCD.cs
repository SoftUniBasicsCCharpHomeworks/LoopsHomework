using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("GCD(a, b) = {0}", b);
                return;
            }
            else if (b == 0)
            {
                Console.WriteLine("GCD(a, b) = {0}", a);
                return;
            }

            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double result;
            double resultRemainder;

            while (true)
            {
                result = a / b;
                resultRemainder = a % b;
                if (resultRemainder != 0)
                {
                    a = b;
                    b = resultRemainder;
                }
                else
                {
                    Console.WriteLine("GCD(a, b) = {0}", b);
                    break;
                }
            }
        }
    }
}
