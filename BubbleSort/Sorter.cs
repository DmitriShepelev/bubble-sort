using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611
#pragma warning disable CA1062

namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            // #1. Implement the method using a loop statements.
            if (array is null)
            {
                throw new ArgumentNullException($"Array cannot be null.");
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[] array)
        {
            // #2. Implement the method using recursion algorithm.
            if (array is null)
            {
                throw new ArgumentNullException($"Array cannot be null.");
            }

            if (array.Length == 0)
            {
                return;
            }

            RecursiveBubbleSort(array, array.Length);
        }

        public static void RecursiveBubbleSort(this int[] array, int length)
        {
            if (length == 1)
            {
                return;
            }

            for (int j = 0; j < length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }

            RecursiveBubbleSort(array, length - 1);
        }

        private static void Swap(ref int i, ref int j)
        {
            int tmp = i;
            i = j;
            j = tmp;
        }
    }
}
