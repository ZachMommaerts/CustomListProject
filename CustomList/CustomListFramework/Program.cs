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
            myList.ToString();
        }
    }
}
