using System;
using System.Collections.Generic;
class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		int i;
        int j = 0;

		for (i = 0; i < n; i++)
		{
			try
			{
				Console.WriteLine(myList[i]);
                j++;
			}
			catch (ArgumentOutOfRangeException) {}   
		}
		return (j);

	}
}
