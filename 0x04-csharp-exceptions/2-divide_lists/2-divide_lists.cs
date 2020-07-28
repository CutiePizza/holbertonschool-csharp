using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        {
            List<int> lista = new List<int>();
            int res = 0, i = 0; 
            for (i = 0; i < listLength; i++)
            {
                try
                {
                    res = list1[i] / list2[i];
                    lista.Add(res);
                }
                catch (ArgumentOutOfRangeException) {
                    Console.WriteLine("Out of range");
                }
                catch (DivideByZeroException) {
                    Console.WriteLine("Cannot divide by zero");
                    res = 0;
                    lista.Add(res);
                }
            }
            return (lista);
        }
    }
