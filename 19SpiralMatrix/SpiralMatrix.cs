using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int z = (x / 2) + 1;
            int width = 3 * (x - 2) + 4;
            int dot = x / 2;

            Console.WriteLine("{0}*{1}*{0}", new string('.', dot), new string('.', width - 2 * dot -2));
        }
    }
}
