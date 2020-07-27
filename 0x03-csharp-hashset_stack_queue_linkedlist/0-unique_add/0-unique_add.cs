using System;
using System.Collections.Generic;
using System.Linq;
    class List
    {
        public static int Sum(List<int> myList)
        {
            List<int> lista = myList.Distinct().ToList();
            int sum = lista.Sum();
            return (sum);
        }
    }
