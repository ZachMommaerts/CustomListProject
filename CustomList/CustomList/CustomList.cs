using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList <T>
    {
        //Member Variables (HAS A)
        T[] items;
        int capacity;
        int count;


        //Constructor
        public CustomList()
        {
            items = new T[capacity];
        }
        //Member Methods (CAN DO)
        public void Add(T itemToAdd)
        {
            for (int i = 0; i < items.Length ; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

    }
}
