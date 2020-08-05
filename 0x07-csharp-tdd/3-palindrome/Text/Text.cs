using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static string ReverseString(string s)
        {
           string onlyLetters = new string(s.Where(Char.IsLetter).ToArray());
           string lowerLetters = onlyLetters.ToLower();
           char[] charArray = lowerLetters.ToCharArray();
           Array.Reverse(charArray);
           string str = new string(charArray);
           return (str);
        }
        public static bool IsPalindrome(string s)
        {
            string newS = ReverseString(s);
            string onlyLetters = new string(s.Where(Char.IsLetter).ToArray());
            string lowerLetters = onlyLetters.ToLower();
            if (s == "" || lowerLetters == newS)
                return (true);
            else
                return (false);

        }
    }
}
