using System;
using System.Collections.Generic;
    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> lista = new List<bool>();
            foreach(int number in myList)
            {
                if (number % 2 == 0)
                    lista.Add(true);
                else
                    lista.Add(false);
            }
            return (lista);
        }
    }
