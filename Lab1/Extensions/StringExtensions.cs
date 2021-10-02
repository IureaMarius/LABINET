using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Extensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string sentence)
        {
            return sentence.Split(',', '\n', '.', ' ').Length;

        }
    }
}
