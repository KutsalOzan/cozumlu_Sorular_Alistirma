﻿namespace Soru_09_Onemli;

class Program
{
    static void Main(string[] args)
    {
        Random yer = new Random();
        Console.SetWindowSize(30,20);
        for(int i = 0; i < 100 ; i++)
        {
            int satir = yer.Next(1,19);
            int sutun = yer.Next(1,29);
            Console.SetCursorPosition(sutun,satir);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*");
            System.Threading.Thread.Sleep(150);
        }
    }
}
