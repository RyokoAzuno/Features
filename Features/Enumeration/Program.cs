using System;
using System.Collections.Generic;
using System.Linq;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 1, 2, 6, 7, 8, 2, 14};
            // TO DO 1
            using (IEnumerator<int> iter = lst.GetEnumerator())
            {
                while (iter.MoveNext())
                    Console.WriteLine(iter.Current);
            }
            // TO DO 2
            var res1 = GetInts();
            var res2 = res1.Select(x => x);
            foreach (var item in res1)
            {
                Console.Write(item);
            }
            // TO DO 3
            Console.WriteLine();
            if(lst.Any(e => e > 0xC))
                Console.WriteLine("Done");
            if(lst.All(e => e < 0xF))
                Console.WriteLine("Done");


            Console.ReadLine();
        }

        static IEnumerable<int> GetInts()
        {
            yield return 1;
            Console.Write(1);
            yield return 2;
            Console.Write(2);
            yield return 3;
            Console.Write(3);
            yield return 4;
            Console.Write(4);
            yield return 5;
            Console.Write(5);
        }
    }
}
