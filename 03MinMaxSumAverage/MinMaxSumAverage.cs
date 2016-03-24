using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            Console.WriteLine("How many numbers will you enter?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your {0} numbers on separate line:", n);
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine("min = {0}", numbers[0]);
            Console.WriteLine("max = {0}", numbers[n - 1]);
            Console.WriteLine("sum = {0}", numbers.Sum());
            Console.WriteLine("avg = {0:F2}", numbers.Sum()/n);
        }
    }
}
