using System;
using System.Collections.Generic;
using System.Text;

namespace SmithLibrary.Extensions
{
    public static class StringExtensions
    {   
        public static bool IsNumeric(this string s)
        {
            long result;
            return long.TryParse(s, out result);
        }
        public static bool IsDateTime(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                DateTime result;
                return DateTime.TryParse(s, out result);
            }
        }
    }
}
