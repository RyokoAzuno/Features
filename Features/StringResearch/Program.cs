using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringResearch
{
    class Program
    {
        private static string str = "How are you, bro!!";

        static void Main(string[] args)
        {
            #region Split and Concat string
            {
                string[] splitStr = str.Split(new[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries); // remove empty entries

                foreach (var item in splitStr)
                {
                    WriteLine($"{item}");
                }

                string s1 = string.Concat(str, "Hey!"); // "How are you, bro!!Hey!"
                WriteLine(s1);

                string s2 = string.Join("*", splitStr); // "How*are*you*bro"
                WriteLine($"{s2}");
            }
            #endregion

            #region String Compare
            {
                string s1 = "hey";
                string s2 = "bro";
                int res = string.Compare(s1, s2);
                if (res == 0)
                    WriteLine("s1 == s2");
                else if (res < 0)
                    WriteLine("s1 before s2");
                else
                    WriteLine("s1 after s2");
            }
            #endregion
            
        }
    }
}
