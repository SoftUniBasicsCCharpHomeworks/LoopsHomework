using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main()
        {
            string secretWord = Console.ReadLine();
            string message = Console.ReadLine();
            int mask = 0;

            for (int i = 0; i < secretWord.Length; i++)
            {
                mask += secretWord[i];
            }


            for (int i = 0; i < mask.ToString().Length; i++)
            {
                mask = mask.ToString().Sum(c => c - '0');
            }

            StringBuilder encryptedMessage = new StringBuilder();

            for (int i = message.Length-1; i >= 0 ; i--)
            {
                if (message[i] % mask ==0)
                {
                    encryptedMessage.Append((char)(message[i] + mask));
                }
                else
                    encryptedMessage.Append((char)(message[i] - mask));
            }

            Console.WriteLine(encryptedMessage.ToString());
        }
    }
}
