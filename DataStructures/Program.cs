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
        }
    }
}
