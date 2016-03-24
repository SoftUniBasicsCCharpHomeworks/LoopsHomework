using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexNumberadecimalToDecimal
{
    class hexNumberadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a hexadecimal number:");
            string hexNumber = Console.ReadLine();

            long decNumber = 0;
            int counter = 0;

            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                int number = 0;
                switch (hexNumber[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = hexNumber[i] - '0'; break;
                }
                decNumber += (long)Math.Pow(16,counter) * number;
                counter++;
            }

            Console.WriteLine(decNumber);

        }
    }
}
