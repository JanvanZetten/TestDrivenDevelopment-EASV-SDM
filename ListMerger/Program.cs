using System;
using System.Collections.Generic;

namespace ListMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9 };
            var list2 = new List<int>() { 1, 2, 3, 5, 6, 7, 8, 9 };

            var merged = MergeList.Merge<int>(list1, list2);

            Console.Write("The merged list:");
            foreach (var item in merged)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();



        }
    }
}
