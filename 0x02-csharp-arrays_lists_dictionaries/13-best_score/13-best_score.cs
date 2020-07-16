using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            int score = 0;
            string ok = "None";
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
    }
