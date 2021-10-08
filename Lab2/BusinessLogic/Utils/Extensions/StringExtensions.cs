using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Utils.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveCharacters(this string originalString, string chars)
        {
            foreach(char c in chars.ToCharArray())
            {
                originalString = originalString.Replace(c.ToString(), String.Empty);
            }
            return originalString;
        }
    }
}
