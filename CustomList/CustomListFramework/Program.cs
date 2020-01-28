using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomList<int> myList = new MyCustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(1);
        }
    }
}
