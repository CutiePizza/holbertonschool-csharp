using System;
using System.Collections.Generic;
using System.Linq;
    class MyStack
    {
       public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
       {
           Console.WriteLine($"Number of items: {aStack.Count}");
           if (aStack.Count == 0)
                Console.WriteLine("Stack is empty");
           else
                Console.WriteLine($"Top item: {aStack.Peek()}");
           if (aStack.Contains(search))
           {
                Console.WriteLine($"Stack contains \"{search}\": True");
                int i = 0;
                while (i < aStack.Count)
                {
                    if (aStack.ElementAt(i) == search)
                        break;
                    i++;
                }
                int j = 0;
                while (j <= i)
                {
                    aStack.Pop();
                    j++;
                }
           }
           else
                Console.WriteLine($"Stack contains \"{search}\": False");
            aStack.Push(newItem);
           return (aStack);
       }
    }
