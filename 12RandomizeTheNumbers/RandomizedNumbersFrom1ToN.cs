using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizedNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int [n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random randNumber = new Random();
        List<int> printed = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int temp = numbers[randNumber.Next(0, n)];
            if (printed.Contains(temp))
            {
                i--;
            }
            else
            {
                printed.Add(temp);
                Console.Write("{0} ",temp);
            }
        }
        Console.WriteLine();
    }
}

