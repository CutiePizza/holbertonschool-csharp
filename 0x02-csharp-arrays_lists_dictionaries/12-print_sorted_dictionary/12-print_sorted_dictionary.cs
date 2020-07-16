using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            List<string> lista = new List<string>();
            foreach(var ok in myDict)
            {   
                lista.Add(ok.Key);
            }
            lista.Sort();
            foreach(string name in lista)
            {
                Console.WriteLine($"{name}: {myDict[name]}");
            }
        }
    }
