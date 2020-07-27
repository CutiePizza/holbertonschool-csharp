using System;
using System.Collections.Generic;
class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> lista = new List<int>();
		int i = 0;
		foreach (int number1 in list1)
		{
			foreach (int number2 in list2)
			{
				if (number1 == number2)
					i = 1;

			}
			if (i == 0)
				lista.Add(number1);
			i = 0;
		}
		foreach (int number1 in list2)
		{
			foreach (int number2 in list1)
			{
				if (number1 == number2)
					i = 1;

			}
			if (i == 0)
				lista.Add(number1);
			i = 0;
		}
		lista.Sort();
		return (lista);
	} 
}

