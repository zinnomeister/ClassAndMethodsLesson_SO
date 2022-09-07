using System;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 6, 7, 8, 9, 0 };
            List<int> result = new List<int>();
            result.AddRange(list1);
            result.AddRange(list2);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }

}