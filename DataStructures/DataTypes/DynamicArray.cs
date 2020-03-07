using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DataTypes
{
    public class DynamicArray
    {
        int current;
        int size = 4;
        int[] values;

        public DynamicArray(int newValue)
        {
            values = new int[size];
            current = 0;
            values[current] = newValue;
            current++;
            Console.WriteLine("Creating Dynamic Array with 1st value {0}", newValue);
        }

        public void Add(int newValue)
        {
            Console.WriteLine("Adding value {0} at {1}", newValue, current);
            if((current+1)<(size-1))
            {
                values[current] = newValue;
                current++;
            }
            else
            {
                int[] newValues = new int[size * 2];
                size = size * 2;
                for(int i = 0; i < current; i++)
                {
                    newValues[i] = values[i];
                }
                newValues[current] = newValue;
                values = (int[]) newValues.Clone();
                current++;
            }
        }

        public void delete(int newValue)
        {
            int indexValue = -1;
            for(int i =0; i<current; i++)
            {
                if(newValue == values[i])
                {
                    indexValue = i;
                }
            }

            if (indexValue > -1)
            {
                Console.WriteLine("Deleting value {0} at {1}", newValue, indexValue);
                for(int i=indexValue; i < current-1; i++)
                {
                    values[i] = values[i + 1];
                }
                current--;
            }
        }

        public void print()
        {
            for (int i = 0; i < current; i++)
            {
                Console.Write(" {0} ", values[i]);
            }
            Console.WriteLine();
        }
    }
}
