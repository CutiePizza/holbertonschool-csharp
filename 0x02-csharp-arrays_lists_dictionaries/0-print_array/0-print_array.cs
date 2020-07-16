using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }
            int[] array = new int[size];
            
            if (size > 0)
            {
            int i;
            for (i = 0; i < array.Length - 1; i++)
            {
                array[i] = i;
                Console.Write($"{array[i]} ");
            }
            array[i] = i;
            Console.Write(array[i]);
            }
            Console.WriteLine();
            return (array);
        }    
    }
