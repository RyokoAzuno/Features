using System;
using System.Collections.Generic;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 1, 2, 6, 7, 8, 2 };

            using (IEnumerator<int> iter = lst.GetEnumerator())
            {
                while (iter.MoveNext())
                    Console.WriteLine(iter.Current);
            }
            Console.ReadLine();
        }
    }
}
