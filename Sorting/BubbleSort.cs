using System;

namespace Sorting
{

    public class Bubble_Sort
    {
        public int[] SortAsc(int[] array)
        {
            int temp;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public int[] SortDesc(int[] array)
        {
            return array;
        }
    }
}
