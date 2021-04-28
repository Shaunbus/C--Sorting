using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            Bubble_Sort bubble = new Bubble_Sort();
            bubble.SortAsc(a);
        }
    }
}
