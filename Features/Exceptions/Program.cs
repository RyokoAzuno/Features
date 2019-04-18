using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Try block!");
                    throw new StackOverflowException();
                }
                catch (Exception)
                {
                    Console.WriteLine("Inner Catch block!");
                    throw;
                }
                finally
                {
                    Console.WriteLine("Inner Finally block!");
                }
            }
            catch(StackOverflowException)
            {
                Console.WriteLine($"Outer Catch block!");
            }
            finally
            {
                Console.WriteLine("Outer Finally block!");
            }

            Console.ReadLine();
        }
    }
}
