using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            char j = '0';
            string k = ", ";
            for (i = 0; i < 100 ; i++)
            {
                
                if (i >= 9)
                    k = ",";
                if (i >= 10)
                    j = ' ';
                if (i != 99)
                {
                    Console.Write("{0}{1}{2}", j, i, k);
                }
                else
                    Console.Write(" " + i + "\n");
            }
        }
    }
}
