namespace GA_SelectionSort_JonathanReed
{
    internal class Program
    {
        /* Jonathan Reed
        * 1/22/2024
        *
        *
        */
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11, 36, 8, 42, 5, 38 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            SelectionSortArray(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void SelectionSortArray(int[] arr)
        {
            int arrayLength = arr.Length;

            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++) /*The outer loop goes through each element, assuming that the current index is where the smallest element should go.*/
            {
                int minIndex = currentIndex;

                // Find the minimum element in the remaining unsorted portion of the array
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++) /*The inner loop iterates through the unsorted part of the array, starting from the current index + 1. It finds the smallest element in the unsorted portion of the array.*/
                {
                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        minIndex = unsortedIndex;
                    }
                }

                // Swap the found minimum element with the element at currentIndex
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp; /*If a smaller element is found, it is swapped with the element at the current index. This ensures that the smallest element in the unsorted portion is placed at the correct position in the sorted portion of the array.*/

                // Display the current state of the array after each iteration
                Console.Write($"Iteration {currentIndex + 1}: ");
                PrintArray(arr);
            }
        }
    }
}