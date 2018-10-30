using System;
using System.Text;

namespace ExtentionMethods
{
    public static class StringExtention
    {
        public static string Reverse(this string str)
        {
            StringBuilder strBuilder = new StringBuilder(str);
            for (int i = 0, j = strBuilder.Length - 1; i < j; i++, j--)
            {
                if (strBuilder[i] != strBuilder[j])
                {
                    strBuilder[i] ^= strBuilder[j];
                    strBuilder[j] ^= strBuilder[i];
                    strBuilder[i] ^= strBuilder[j];
                }
            }

            return strBuilder.ToString();
        }
    }
}
