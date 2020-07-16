using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            int score = 0;
            string ok = string.Empty;
            if (myList.Count > 0)
            {
            foreach (KeyValuePair<string, int> entry in myList)
            {   
                if (entry.Value > score)
                {
                    score = entry.Value;
                    ok = entry.Key;
                }
            }
            return (ok);
            }
            return ("None");
        }
    }
