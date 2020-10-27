using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        Console.WriteLine(myStrQ.Concatenate());

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Concatenate();

        Console.WriteLine("----------");

        Queue<int> myCharQ = new Queue<int>();
        myCharQ.Enqueue(1);
        myCharQ.Enqueue(2);
        myCharQ.Enqueue(3);
        Console.WriteLine(myCharQ.Concatenate());
    }
}
