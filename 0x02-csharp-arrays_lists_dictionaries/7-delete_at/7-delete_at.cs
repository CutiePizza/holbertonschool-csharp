﻿using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> DeleteAt(List<int> myList, int index)
        {
            if (index < 0 || index >= myList.Count)
            {
                Console.WriteLine("Index is out of range");
                return (myList);
            }
            int i;
            for (i = index; i < myList.Count - 1; i++)
            {
                myList[i] = myList[i + 1];
            }
            myList.RemoveRange(myList.Count - 1, 1);
            return(myList);
        }
    }
