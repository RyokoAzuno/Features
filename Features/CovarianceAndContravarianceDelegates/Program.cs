using System;

using static System.Console;

namespace CovarianceAndContravarianceDelegates
{
    class Base
    {
        public string Name { get; set; }
    }
    class Derived : Base
    {
        public int Age { get; set; }
    }

    class Program
    {
        delegate Base CoDelegate(string name);
        delegate void ContraDelegate(Derived d);
        delegate T CoGenDelegate<out T>(string name);
        delegate void ContraGenDelegate<in T>(T obj);

        static void Main(string[] args)
        {
            {
                WriteLine($"---------------Covariance------------");
                CoDelegate coDel;
                coDel = Covariance;
                Base b = coDel("Mike");
                WriteLine(b.Name);

                WriteLine($"---------------Contravariance------------");
                ContraDelegate contraDel;
                contraDel = Contravariance;
                Derived d = new Derived { Name = "Ann", Age = 15 };
                contraDel(d);
                WriteLine(d.Name);
            }
            {
                WriteLine($"---------------Generic Covariance------------");
                CoGenDelegate<Base> coGenDel;
                coGenDel = Covariance;
                Base b = coGenDel("Steve");
                WriteLine(b.Name);

                WriteLine($"---------------Generi Contravariance------------");
                ContraGenDelegate<Derived> contraGenDel;
                contraGenDel = Contravariance;
                Derived d = new Derived { Name = "Ann", Age = 15 };
                contraGenDel(d);
                WriteLine(d.Name);
            }
        }

        static Derived Covariance(string name) => new Derived { Name = $"{name} from Covariance", Age = 10 };
        static void Contravariance(Base b) => b.Name = $"{b.Name} from Contravariance";
    }
}
