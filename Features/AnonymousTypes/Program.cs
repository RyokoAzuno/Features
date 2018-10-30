using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "Ryoko", Age = 28};
            WriteLine($"{person.GetType().Name} - {person.Name} - {person.Age}");

            WriteLine();

            var persons = new[] { new { Name = "Mike", Age = 29 }, person, new { Name = "Ann", Age = 30 } };
            foreach (var item in persons)
                WriteLine($"{item.Name} - {item.Age}");
        }
    }
}
