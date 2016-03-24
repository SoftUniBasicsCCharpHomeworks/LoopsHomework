using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a positive number n (n<20): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j <= i + n; j++)
                {
                    Console.Write("{0} ", j );
                }
                Console.WriteLine();
            }

        }
    }
}
