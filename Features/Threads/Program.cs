using System;
using System.Collections.Generic;
using System.Threading;

using static System.Console;

namespace Threads
{
    class Info
    {
        //public int Symbol { get; set; }
        public int X { get; set; }
        //public int Y { get; set; }
        public ConsoleColor Color { get; set; }
    }

    class Program
    {
        static readonly object locker = new object();

        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            string str = string.Empty;
            Random rnd = new Random();

            Write($"Enter number of lines(dont duplicate): ");
            str = ReadLine();

            foreach (var item in str.Split(new char[] { ' ' }))
                lst.Add(Convert.ToInt32(item));

            foreach (var item in lst)
            {
                Info inf = new Info() { Color = (ConsoleColor)rnd.Next(1, 15), X = item };
                Thread th = new Thread(new ParameterizedThreadStart(PrintSymbol));
                th.Start(inf);
            }
        }
        static void PrintSymbol(object info)
        {
            Random rnd = new Random();
            Info inf = (Info)info;
            int l = inf.X;
            int posx = 0;
            char ch = (char)1;

            for (int i = 0; i < 50; i++)
            {
                lock (locker)
                {
                    ForegroundColor = inf.Color;
                    SetCursorPosition(posx, l);
                    Write($"{ch}");
                    posx = posx + 1;
                }
                Thread.Sleep(100);
            }
        }
    }
}
