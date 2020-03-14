using System;

namespace DataStructures.DataTypes
{
    public class Queue
    {
        public Node head;
        public Node tail;

        public Queue(int value)
        {
            head = new Node(value);
            head.next = null;
            tail = head;
        }

        public Node Enqueue(int value)
        {
            var current = new Node(value);
            current.next = head;
            head = current;
            return current;
        }

        public Node Dequeue()
        {
            var current = head;

            if (current == tail)
            {
                head = null;
                tail = null;
                return current;
            }

            while (current.next != tail)
            {
                current = current.next;
            }

            tail = current;
            tail.next = null;
            return current.next;
        }

        public void Print()
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
