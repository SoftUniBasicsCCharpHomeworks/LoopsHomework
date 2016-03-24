using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter a decimal number:");
            long decNumber = long.Parse(Console.ReadLine());

            string binNumber = "";
            if (decNumber==0)
            {
                binNumber = "0";
            }
            else
            {
                while (decNumber > 0)
                {
                    int remainder = (int)decNumber % 2;
                    decNumber /= 2;
                    binNumber = remainder + binNumber;
                }
            }

            Console.WriteLine(binNumber);
        }
    }
}
