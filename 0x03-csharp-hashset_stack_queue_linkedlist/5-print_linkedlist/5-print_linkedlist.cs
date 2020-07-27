using System;
using System.Collections.Generic;
using System.Linq;
    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            LinkedList<int> llista = new LinkedList<int>();
            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                    llista.AddLast(i);
                foreach (int num in llista)
                    Console.WriteLine(num);
            }
            return (llista);
        }
    }
