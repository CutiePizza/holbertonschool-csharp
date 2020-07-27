using System;
using System.Collections.Generic;
using System.Linq;
class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		Console.WriteLine($"Number of items: {aQueue.Count}");
		if (aQueue.Count == 0)
			Console.WriteLine("Queue is empty");
		else
			Console.WriteLine($"First item: {aQueue.Peek()}");
        aQueue.Enqueue(newItem);
		if (aQueue.Contains(search))
		{
			Console.WriteLine($"Queue contains \"{search}\": True");
			int i = 0;
			while (i < aQueue.Count)
			{
				if (aQueue.ElementAt(i) == search)
					break;
				i++;
			}
			int j = 0;
			while (j <= i)
			{
				aQueue.Dequeue();
				j++;
			}
		}
		else
			Console.WriteLine($"Queue contains \"{search}\": False");
		return (aQueue);
	}
}
