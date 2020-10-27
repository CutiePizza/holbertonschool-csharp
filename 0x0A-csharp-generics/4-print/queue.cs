using System;
/// <summary>
/// QUeue Class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    int count;

    /// <summary>
    /// head setter/getter
    /// </summary>
    /// <value></value>
    public Node head {
        get;
        set;
    }

    /// <summary>
    /// tail getter/setter
    /// </summary>
    /// <value></value>
    public Node tail {
        get;
        set;
    }
    
    /// <summary>
    /// Check Type of a queue
    /// </summary>
    /// <returns>Type of a Queue</returns>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    /// <summary>
    /// Enqueue
    /// </summary>
    /// <param name="value">value to put</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (this.tail == null)
        {
            this.head = this.tail = newNode;
            count += 1;
        }
        else
        {
            this.tail.Next = newNode;
            this.tail = newNode;
            count += 1;
        }

    }

    /// <summary>
    /// Dequeue a queueu
    /// </summary>
    /// <returns>Value of node deleted</returns>
    public T Dequeue()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node p = this.head;
        this.head = this.head.Next;
        count -= 1;
        return (p.Value);
    }

    /// <summary>
    /// Count
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return this.count;
    }
    /// <summary>
    /// Peek first value
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (this.head.Value);
    }

    /// <summary>
    /// Print Queue
    /// </summary>
    public void Print()
    {
        if (this.head == null)
            Console.WriteLine("Queue is empty");
        Node p = this.head;
        while(p != null)
        {
            Console.WriteLine(p.Value);
            p = p.Next;
        }
    }

    /// <summary>
    /// Class Node
    /// </summary>
    public class Node
    {
        T value;
        Node next = null;

        /// <summary>
        /// Value property
        /// </summary>
        /// <value>value</value>
        public T Value {
            get => this.value;
            set {
                this.value = value;
            }
        }
        /// <summary>
        /// Next property
        /// </summary>
        /// <value>value</value>
        public Node Next {
            get => this.next;
            set {
                this.next = value;
            }
        }
        /// <summary>
        /// Node constructor
        /// </summary>
        /// <param name="value">Value</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}


