using System;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 8, 4, 10, 9, 11 };
            Console.WriteLine("排序前:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Sort(arr);

            Console.WriteLine("排序后:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void Sort(int[] arr)
        {
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                int minElement = arr[i];
                int minIndex = i;
                for (int j = i + 1; j < arrLength; j++)
                {
                    var currentElement = arr[j];
                    if (currentElement < minElement)
                    {
                        minElement = currentElement;
                        minIndex = j;
                    }
                }

                arr[minIndex] = arr[i];
                arr[i] = minElement;
            }
        }
    }
}
