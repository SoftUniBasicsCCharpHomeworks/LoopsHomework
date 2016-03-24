using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string roomState = Console.ReadLine();

            StringBuilder rooms = new StringBuilder();

            for (int i = 0; i < n ; i++)
            {
                if (i == 0)
                {
                    rooms.Append(roomState[i]);
                }
                else
                    rooms.Append(roomState[i % roomState.Length]);
            }
            string input = Console.ReadLine();
            //Console.WriteLine(rooms);

            int prevPos = n / 2;
            int newPos = 0;
            while (input != "END")
            {
                var command = input.Split(' ').ToArray();
                int position = Int32.Parse(command[1]);
                switch (command[0])
                {
                    case "LEFT":
                        newPos = prevPos - (position + 1);
                         if (newPos >= 0 && newPos != prevPos)
                        {
                            if (rooms[newPos] == 'D')
                            {
                                rooms[newPos] = 'L';
                            }
                            else
                            {
                                rooms[newPos] = 'D';
                            }
                            prevPos -= (position + 1);
                        }
                        else if (newPos < 0 )
                        {
                            newPos = 0;
                            if (rooms[0] == 'D' && newPos != prevPos)
                            {
                                rooms[0] = 'L';
                            }
                            else if (rooms[0] == 'L' && newPos != prevPos)
                            {
                                rooms[0] = 'D';
                            }
                            prevPos =0;
                        }
                        break;
                    case "RIGHT":
                        newPos = prevPos + (position + 1);
                        if (newPos < n && newPos != prevPos)
                        {
                            if (rooms[newPos] == 'D')
                            {
                                rooms[newPos] = 'L';
                            }
                            else
                            {
                                rooms[newPos] = 'D';
                            }
                            prevPos += (position + 1);
                        }
                        else if (newPos > n -1 )
                        {
                            newPos = n - 1;
                            if (rooms[n - 1] == 'D' && newPos != prevPos)
                            {
                                rooms[n - 1] = 'L';
                            }
                            else if (rooms[n - 1] == 'L' && newPos != prevPos)
                            {
                                rooms[n - 1] = 'D';
                            }
                            prevPos = n - 1;
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            string roomFinal = rooms.ToString();
            int countD = roomFinal.Split('D').Length - 1;
            Console.WriteLine(countD * (int)'D');
            //Console.WriteLine(rooms);

        }
    }
}
