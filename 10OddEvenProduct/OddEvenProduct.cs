using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers(separated by a space):");
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 1; i <= numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= numbers[i-1];
                }
                else
                {
                    oddProduct *= numbers[i-1];
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes\nproduct = {0}", evenProduct);
            }
            else
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", evenProduct,oddProduct);

        }
    }
}
