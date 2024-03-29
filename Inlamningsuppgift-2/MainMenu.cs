﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift_2
{
    class MainMenu
    {//ConsoleKeyInfo key = Console.ReadKey(); // creating key variable thats equal to key pressed
        public static void MainMenuChoice()
        {
        int x;
        int y;
        char letter;
        int menuChoice;

            while (true)
            {
                Console.WriteLine(@" Hello. This application indicates which buttons you are pressing.
It also plays a melody by random generated tones.
Choose mode.
1. Keyboard press indicator
2. Random generated melody.
");
                try
                {
                    menuChoice = Convert.ToInt32(Console.ReadLine());


                    if (menuChoice == 1)
                    {
                        Console.Clear();
                        Console.Write(Keyboard.keyboardString);
                        Console.WriteLine("");
                        while (true) // infinite loop
                        {
                            letter = ' ';
                            x = 0;
                            y = 0;
                            Console.SetCursorPosition(x, y);
                            Console.Write(letter);

                            CheckWhichKey.CheckWhichKeyMethod();
                        }
                    }
                    else if (menuChoice == 2)
                    {
                        RandomTones.RandomTonePlayer();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Input number was not in correct format please try again with either 1 or 2 \n");
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Input number was not in correct format please try again with either 1 or 2 \n");
                }
            }
        }
    }
}
