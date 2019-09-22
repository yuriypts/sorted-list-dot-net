using System;
using System.Collections.Generic;

namespace SortList
{
    public class SortedList
    {
        private int[] customArr;

        public int[] SortedListByAsc(int[] arr)
        {
            if (arr == null || arr.Length < 1)
                return arr;

            int[] sortedArr = new int[arr.Length];
            customArr = arr.Clone() as int[];

            for (int num = 0; num < arr.Length; num++)
            {
                int value = customArr[0];

                for (int q = 0; q < customArr.Length; q++)
                {
                    if (customArr[q] < value)
                    {
                        value = customArr[q];
                    }
                }

                customArr = Array.FindAll(customArr, x => x != value);

                sortedArr[num] = value;
            }

            return sortedArr;
        }
    }
}
