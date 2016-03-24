using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFactors
{
    class FourFactors
    {
        static void Main()
        {
            decimal fg = decimal.Parse(Console.ReadLine());
            decimal fga = decimal.Parse(Console.ReadLine());
            decimal threep = decimal.Parse(Console.ReadLine());
            decimal tov = decimal.Parse(Console.ReadLine());
            decimal orb = decimal.Parse(Console.ReadLine());
            decimal opp = decimal.Parse(Console.ReadLine());
            decimal ft = decimal.Parse(Console.ReadLine());
            decimal fta = decimal.Parse(Console.ReadLine());
            Console.WriteLine("eFG% {0:F3}",(fg + 0.5m * threep)/fga);
            Console.WriteLine("TOV% {0:F3}",tov /(fga + 0.44m * fta + tov));
            Console.WriteLine("ORB% {0:F3}",orb / (orb + opp));
            Console.WriteLine("FT% {0:F3}", ft / fga);
        }
    }
}
