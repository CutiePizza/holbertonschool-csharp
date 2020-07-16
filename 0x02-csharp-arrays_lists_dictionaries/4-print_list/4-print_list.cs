using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }
            List<int> lista = new List<int>();
            if (size != 0)
            {
            for (int i = 0; i < size; i++)
            {
                lista.Add(i);
                if (i != size -1)
                    Console.Write($"{lista[i]} ");
                else
                    Console.WriteLine($"{lista[i]}");
            }
            }
            else
                Console.WriteLine();
            return(lista);
        }
    }
