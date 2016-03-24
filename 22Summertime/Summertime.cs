using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summertime
{
    class Summertime
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int bottom = 2 * n;
            int top = n + 1;
            int k = 2;

            Console.WriteLine("{0}{1}", new string(' ',n / 2), new string('*', top));
            for (int i = 0; i < top / 2; i++)
            {
                Console.WriteLine("{0}*{1}*", new string(' ', n / 2), new string(' ', n-1));
            }
            for (int i = n/2-1; i > 0; i--)
            {
                Console.WriteLine("{0}*{1}*", new string(' ', i), new string(' ', (n - 1) + k));
                k += 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", new string('.', bottom - 2));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", new string('@', bottom - 2));
            }
            Console.WriteLine("{0}", new string('*', bottom ));
        }
    }
}
