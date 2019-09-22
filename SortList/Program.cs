using System;

namespace SortList
{
    class Program
    {
        static int[] arr = new int[] { 1, 6, 3, 9, 8, 5 };
        //static int[] arr = new int[] { 6, 3, 9, 4, 2 };

        static void Main(string[] args)
        {
            SortedList sortList = new SortedList();

            Console.WriteLine("Unsorted List");

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine("number is - {0}", arr[i]);
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Sorted List");

            int[] sortedList = sortList.SortedListByAsc(arr);

            for (int numS = 0; numS < sortedList.Length; numS++)
            {
                Console.WriteLine("number is - {0}", sortedList[numS]);
            }

            Console.ReadKey();
        }
    }
}
