using System;

namespace Text
{
    /// <summary>
    /// class str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Camel Case task
        /// </summary>
        /// <param name="s"></param>
        /// <returns>How many words</returns>
        public static int CamelCase(string s)
        {
           int j = 1;
           int k = 0;
           int i = 0;
           while (k != s.Length && i != s.Length)
           {
                for (i = k; i < s.Length; i++)
                {
                    if (s[i] > 'A' && s[i] < 'Z')
                    {
                        j++;
                        k = i + 1;
                        break;
                    }
                }
           }
            return (j); 
        }
    }
}
