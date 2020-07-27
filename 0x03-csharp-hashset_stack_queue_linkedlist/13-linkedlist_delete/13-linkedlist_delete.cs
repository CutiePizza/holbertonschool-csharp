using System;
using System.Collections.Generic;
    class LList
    {
        public static void Delete(LinkedList<int> myLList, int index)
        {
            LinkedListNode<int> node = myLList.First;
            int i = 0;
            if (index == 0)
            {
                myLList.RemoveFirst();
            }
            else if (index == myLList.Count - 1)
            {
                myLList.RemoveLast();
            }
            else
            {
                while(myLList.Count > i && node.Next != null)
                {
                    if (i == index)
                    {
                        myLList.Remove(node);
                        break;
                    }
                    node = node.Next;
                    i++;
                }
            }

        }
    }
