using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListFramework
{
    public class MyCustomList<T> : IEnumerable
    {
        //Member Variables (HAS A)
        public T[] items;
        
        int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        int count;
        public int Count { get { return count; }}
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }


        //Constructor
        public MyCustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
            
            
        }
        //Member Methods (CAN DO)
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] temporaryArray = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    temporaryArray[i] = items[i];

                }

                items = temporaryArray;
            }
            
            items[count] = itemToAdd;
            count++;
        }
        public bool Remove(T itemToRemove)
        {
            bool removed = false;
            int j = 0;
            T[] temporaryArray = new T[Capacity];
            for (int i = j; i < Count; i++)
            {
                if(Equals(items[i], itemToRemove) && (i == j))
                {
                    removed = true;
                }
                else
                {
                    temporaryArray[j] = items[i];
                    j++;
                }
            }
            if(removed)
            {
                count--;
                items = temporaryArray;
            }
            return removed;
        }
        public override string ToString()
        {
            StringBuilder itemString = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                itemString.Append(items[i].ToString());
            }
            return itemString.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
            yield return "List is complete";
        }
    }
}
