using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string[] cards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < 13 ; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    
                    switch (j)
                    {
                        case 1: Console.Write("{0}{1} ", cards[i], '\u2663'); break;
                        case 2: Console.Write("{0}{1} ", cards[i], '\u2666'); break;
                        case 3: Console.Write("{0}{1} ", cards[i], '\u2665'); break;
                        case 4: Console.Write("{0}{1} ", cards[i], '\u2660'); break;
                            default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
