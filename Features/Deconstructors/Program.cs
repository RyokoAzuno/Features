using System;

using static System.Console;

namespace Deconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Mike", Password = "12345", Age = 20 };

            (string name, string password, int age) = user;
            WriteLine($"{name} - {password} - {age}");

        }
    }
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int  Age { get; set; }

        public void Deconstruct(out string name, out string password, out int age)
        {
            name = this.Name;
            password = this.Password;
            age = this.Age;
        }
    }
}
