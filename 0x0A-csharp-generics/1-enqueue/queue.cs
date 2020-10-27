﻿using System;
/// <summary>
/// QUeue Class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{

    Node head = null;
    Node tail = null;
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
        }
        else
        {
            this.tail.Next = newNode;
            this.tail = newNode;
        }

    }

    public int Count()
    {
        Node p = this.head;
        int i = 0;
        if (p == null)
            return 0;
        while (p != null)
        {
            p = p.Next;
            i++;
        }
        return i;
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


