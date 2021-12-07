using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extention.Helper
{
   public static class Extention
    {
        public static int CheckString(this string str, string pattern)
        {
           int wordCount = 0;

            foreach (Match m in Regex.Matches(str, pattern))
            {
                wordCount++; 
            }
            return wordCount;
            
            

        }
    }
}
