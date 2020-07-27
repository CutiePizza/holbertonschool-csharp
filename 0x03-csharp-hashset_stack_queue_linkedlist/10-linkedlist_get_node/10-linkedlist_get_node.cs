using System;
using System.Collections.Generic;
    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            if (myLList.Count == 0)
                return (0);
            int i = 0, number = 0;
            foreach (int num in myLList)
            {
                if (i == n)
                {
                    number = num;
                    break;
                }
                i++;
            }
            return (number);
        }
    }