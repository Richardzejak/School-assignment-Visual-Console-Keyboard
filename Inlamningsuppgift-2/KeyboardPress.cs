﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    public class KeyboardPress
    {
        public static void ChangeTextColor(string letter, int x, int y, int freq) //handles keyboard presses with information from keypress events in main structure
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(x, y);
            Console.Write(letter);
            Console.Beep(freq, 150);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.Write(letter);
            Console.SetCursorPosition(0, 0);
        }
    }
}
