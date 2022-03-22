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

    /// <summary>Prints values at all nodes</summary>
    public void Print()
    {
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
        {
            Node skimmer = head;
            while (skimmer != null)
            {
                Console.WriteLine(skimmer.value);
                skimmer = skimmer.next;
            }
        }
    }

    /// <summary>Concatonates queue</summary>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(String) && typeof(T) != typeof(Char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }
        Node skimmer = head;
        string concat = "";
        while (skimmer != null)
        {
            concat += skimmer.value;
            if (typeof(T) == typeof(String) && skimmer.next != null)
                concat += " ";
            skimmer = skimmer.next;
        }
        return concat;
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