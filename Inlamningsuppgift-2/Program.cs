﻿using Inlamningsuppgift_2;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Program
{
    static void Main()
    {
        Console.SetWindowSize(150, 20); // Resize console window

        MainMenu.MainMenuChoice();
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }
}
