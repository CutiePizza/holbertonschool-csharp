using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
            int num = 0;
            foreach (var item in myDict)
                num++;
            return(num);
        }
    }
