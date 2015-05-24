using System;
using System.Collections.Generic;

class GameOfBits
{
    static void Main(string[] args)
    {
        uint num = uint.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (true)
        {
            switch (command)
            {
                case"Odd":
                    uint mask = 0;
                    for (int i = 0; i <= 31; i += 2)
                    {
                        uint bit = (num >> i) & 1;
                        mask |= bit << (i / 2);
                    }
                    break;
                case"Even":
                    mask=num;
                    for (int i = 1; i <= 31; i += 2)
                    {
                        uint bit = (num >> i) & 1;
                        mask |= bit << (i / 2);
                    }
                    break;
                case "Game Over!":
                    int count = 0;
                    for (int i = 0; i < 31; i++)
                    {
                        if ()
                        {
                            
                        }
                    }
                    break;
            }

            if (command=="Gane Over!")
            {
                break;
            }
            command = Console.ReadLine();
        }
    }
}
