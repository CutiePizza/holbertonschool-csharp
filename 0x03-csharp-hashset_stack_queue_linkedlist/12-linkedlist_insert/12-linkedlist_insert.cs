using System;
using System.Collections.Generic;
    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> node = new LinkedListNode<int>(n);
            LinkedListNode<int> nodeNext = myLList.First;

            if (nodeNext.Value > n)
            {
                myLList.AddFirst(node);
                return (node);
            }
            int i = 0;
            while(myLList.Count > i && nodeNext.Next != null && nodeNext.Next.Value < n)
            {
                nodeNext = nodeNext.Next;
                i++;
            }
            myLList.AddAfter(nodeNext, node);
            return (node);
        }
    }
