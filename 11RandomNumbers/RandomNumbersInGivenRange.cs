using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter a number max: ");
        int max = int.Parse(Console.ReadLine());

        Random randNumber = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(randNumber.Next(min, max + 1)+ " ");
        }
        Console.WriteLine();
    }
}

