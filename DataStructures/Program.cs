using DataStructures.DataTypes;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dynamic Array ");
            var dynamicArray = new DynamicArray(5);
            dynamicArray.Add(2);
            dynamicArray.Add(4);
            dynamicArray.print();
            dynamicArray.delete(4);
            dynamicArray.print();

            Console.WriteLine("LinkedList");
            var linkedList = new LinkedList(5);
            linkedList.Add(2);
            linkedList.Add(4);
            linkedList.Delete(2);
            linkedList.print();

        }
    }
}
