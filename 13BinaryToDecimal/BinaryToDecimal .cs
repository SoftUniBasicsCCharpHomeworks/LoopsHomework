using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter binary binNumber:");
            string binNumber = Console.ReadLine();
            long decNumber=0;

            for (int i = binNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (binNumber[i] == '1')
                {
                    decNumber += (long)Math.Pow(2, j);
                }
                
            }
            Console.WriteLine(decNumber);

        }
    }
}
