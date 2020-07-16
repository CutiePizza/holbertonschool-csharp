using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] jarray = {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    if (j != jarray[i].Length -1)
                        Console.Write("{0} ", jarray[i][j]);
                    else
                        Console.Write("{0}", jarray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
