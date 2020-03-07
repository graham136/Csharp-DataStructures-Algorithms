using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataTypes
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }

    }
    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList(int value)
        {
            head = new Node(value);
            head.next = null;
            tail = head;
        }

        public Node Add(int value)
        {
            var current = new Node(value);
            current.next = null;
            tail.next = current;
            tail = current;
            return current;
        }

        public Node Delete(int value)
        {
            var current = head;
            if (current.data == value)
            {
                head = head.next;
                return current;
            }

            while (current.next != null && current.next.data != value)
            {
                current = current.next;
            }

            if (current.next.data == value)
            {
                if (current.next == tail)
                {
                    tail = current;
                    tail.next = null;
                    return current.next;
                }
                var found = current.next;
                current.next = current.next.next;
                return found;
            }
            else
            {
                return null;
            }
        }

        public void print()
        {
            var current = head;
            if (current != null)
            {
                Console.Write(" {0}", current.data);

                current = current.next;
                while (current != null)
                {
                    Console.Write(" {0} ", current.data);
                    current = current.next;
                }
            }
            Console.WriteLine();

        }
    }
}
