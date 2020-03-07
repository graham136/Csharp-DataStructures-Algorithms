using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataTypes
{
    
    public class Stack
    {
        Node head;

        public Stack(int value)
        {
            var current = new Node(value);
            current.next = null;
            head = current;
        }

        public void pushValue(int value)
        {
            var current = new Node(value);
            current.next = head;
            head = current;

        }

        public int popValue()
        {
            var current = head;
            if (head == null) 
            {
                return -1;
            }
            var value = head.data; 
            head = head.next;
            return value;
        }

        public void printValues()
        {
            var current = head;
            if(current == null)
            {
                return;
            }
            while(current != null)
            {
                Console.Write(" {0} ",current.data);
                current = current.next;
            }
        }
    }
}
