using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            if (myList.Count - 1 == 0)
                return ("None");
            int score = int.MinValue;;
            string ok = "";
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
