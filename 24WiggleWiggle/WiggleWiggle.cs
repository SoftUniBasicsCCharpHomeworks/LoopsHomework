using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WiggleWiggle
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
        ulong mask = 1;

        for (int i = 0; i < numbers.Length; i += 2)
        {
            for (int evenPos = 0; evenPos < 64; evenPos += 2)
            {
                ulong firstBits = (numbers[i] >> evenPos) & mask;
                ulong secondBits = (numbers[i + 1] >> evenPos) & mask;

                numbers[i] = numbers[i] & ~(mask << evenPos);
                numbers[i + 1] = numbers[i + 1] & ~(mask << evenPos);

                numbers[i] = numbers[i] | (secondBits << evenPos);
                numbers[i + 1] = numbers[i + 1] | (firstBits << evenPos);
            }

            numbers[i] = numbers[i] ^ ~(mask << 63);
            numbers[i + 1] = numbers[i + 1] ^ ~(mask << 63);

            Console.WriteLine("{0} {1}", numbers[i], Convert.ToString((long)numbers[i], 2).PadLeft(63, '0'));
            Console.WriteLine("{0} {1}", numbers[i+1], Convert.ToString((long)numbers[i+1], 2).PadLeft(63, '0'));
        }
    }
}

