using System;

namespace HeapSort
{
    internal class Program
    {
        static void HeapSort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                Heap(arr, arr.Length, i);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);
                Heap(arr, i, 0);
            }
        }

        static void Heap(int[] arr, int size, int root)
        {
            int max = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < size && arr[left] > arr[max])
                max = left;
            if (right < size && arr[right] > arr[max])
                max = right;
            if (max != root)
            {
                (arr[max], arr[root]) = (arr[root], arr[max]);
                Heap(arr, size, max);
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = { 4, 5, 6, 78, 1, 3, 5, 6, 2, 9, 7, 5, 8, 5, 6, 77, 8, 0 };

            HeapSort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }
    }
}
