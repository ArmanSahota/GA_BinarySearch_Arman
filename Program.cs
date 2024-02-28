using System;

namespace GA_BinarySearch_Arman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample sorted array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Element to search
            int target = 5;

            // Test IterativeBinarySearch
            int iterativeResult = BinarySearch.IterativeBinarySearch(array, target);

            if (iterativeResult != -1)
                Console.WriteLine($"Iterative Binary Search: Element {target} is at index {iterativeResult}");
            else
                Console.WriteLine($"Iterative Binary Search: Element {target} not found");

            // Test RecursiveBinarySearch
            int recursiveResult = BinarySearch.RecursiveBinarySearch(array, target, 0, array.Length - 1);

            if (recursiveResult != -1)
                Console.WriteLine($"Recursive Binary Search: Element {target} is at index {recursiveResult}");
            else
                Console.WriteLine($"Recursive Binary Search: Element {target} not found");
        }
    }

    internal static class BinarySearch {
        public static int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0; 
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (array[mid] == target)
                    return mid;

                // If target greater, ignore left half
                if (array[mid] < target)
                    left = mid + 1;
                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If we reach here, then the element was not present
            return -1;
        }
        // Recursive binary search function
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (array[mid] == target)
                    return mid;

                // If target is smaller than mid, search left half
                if (array[mid] > target)
                    return RecursiveBinarySearch(array, target, left, mid - 1);

                // If target is greater than mid, search right half
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }

            // If we reach here, then the element was not present
            return -1;
        }

    }




}