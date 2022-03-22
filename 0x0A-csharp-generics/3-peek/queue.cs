using System;

/// <summary>Generic class</summary>
class Queue<T>
{
    Node head = null;
    Node tail = null;
    int count = 0;

    /// <summary>Returns type of Queue object</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
    public int Count()
    {
        return this.count;
    }
    /// <summary>Creates a Node</summary>
    public void Enqueue(T value)
    {
        this.count += 1;
        if (count == 1)
        {
            this.head = new Node(value);
            this.tail = head;
        } else {
            this.tail.next = new Node(value);
            this.tail = this.tail.next;
        }
    }

    /// <summary>Removes a Node</summary>
    public T Dequeue()
    {
        if (this.count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        } else {
            T value = head.value;
            head = head.next;
            count -= 1;
            return value;
        }
    }

    /// <summary>Looks at the head value</summary>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        } else {
            return head.value;
        }
    }

    /// <summary>Nodes for queuing</summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;
        public Node (T value)
        {
            this.value = value;
        }
    }
}