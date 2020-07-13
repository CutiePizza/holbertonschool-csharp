using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: " + percent.ToString("0.00%"));
        Console.WriteLine("Currency: " + string.Format(new CultureInfo("en-US.utf-8"), "{0:c}", currency));
	}
}