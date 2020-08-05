using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// String class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Check for a unique character
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Index of the unique characater</returns>
      public static int UniqueChar(string s)
      {
        int i, j;  
        bool isUnique = false;  
        char[] chars = s.ToCharArray();  
        for (i = 0; i < chars.Length; i++)  
        {  
            isUnique = false;  
            for (j = 0; j < chars.Length; j++)  
            {  
                if ((i != j) && (chars[i] == chars[j]))  
                {  
                    isUnique = true;  
                    break;  
                }  
            }  
            if (isUnique ==false)    
                return (i);  
        }  
        return (-1);  
      }
    }
}
