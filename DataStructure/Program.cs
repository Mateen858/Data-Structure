using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            Console.WriteLine("please enter a number to search");

            int search = Convert.ToInt32((Console.ReadLine()));
            if (myList.Contains(search))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadKey();
        }
    }
}
