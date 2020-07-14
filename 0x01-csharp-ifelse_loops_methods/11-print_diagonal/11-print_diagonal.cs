using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int i, j;

            if (length <= 0)
		        Console.WriteLine();
            else
            {
                for (i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("\\");
                    }
                    else
                    {
                        for (j = 0; j < i; j++)
                        {
                           Console.Write(' ');
                        }
                        Console.WriteLine("\\");
                    }
                }
                Console.WriteLine();
            }
        }
    }
