using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        long decNumber = long.Parse(Console.ReadLine());

        string hexNumber = "";

        if (decNumber == 0)
        {
            hexNumber = "0";
        }
        else
        {

            while (decNumber != 0)
            {
                long reminder = decNumber % 16;

                switch (reminder)
                {
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                    default: hexNumber = reminder + hexNumber; break;
                }

                decNumber /= 16;
            }
        }
        Console.WriteLine(hexNumber);
    }
}

