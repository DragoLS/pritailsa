﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pritaivsheysa_zmey
{
    internal class zmeya
    {
        public void zmey()
        {
            bool a=false;
            int x = 10;
            int y = 5;
            ConsoleKeyInfo key = Console.ReadKey();
            Thread tim = new Thread(_ =>
            {
                while (a == false)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        y--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        y++;
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        x++;
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        x--;
                    }
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("#");
                    for (int i = 0; i < (int)border.hght; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("|");
                        Console.SetCursorPosition((int)border.wdth, i);
                        Console.WriteLine("|");
                    }
                    for (int i = 1; i < (int)border.wdth; i++)
                    {
                        Console.SetCursorPosition(i, 0);
                        Console.WriteLine("-");
                        Console.SetCursorPosition(i, (int)border.hght);
                        Console.WriteLine("-");
                    }
                    if (y == 10)
                    {
                        a = true;
                    }
                    if (y == 0)
                    {
                        a = true;
                    }
                    if (x == 0)
                    {
                        a = true;
                    }
                    if (x == 20)
                    {
                        a = true;
                    }
                    Thread.Sleep(200);
                    Console.Clear();
                }
                Console.WriteLine("Game over");
            });
            tim.Start();
            while (a == false)
            {
                key = Console.ReadKey();

            }
            Console.Clear();
        }
    }
}
