using System;

namespace Sort.Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 8, 4, 13, 11, 10, 9 };
            Console.Write("排序前:");
            ShowResult(arr);

            Console.WriteLine();
            Sort(arr);

            Console.WriteLine();
            Console.Write("排序后:");
            ShowResult(arr);
        }

        static void Sort(int[] arr)
        {
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine($"进行第{i + 1}次一层循环：");
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    Console.Write($"    进行第{j + 1}次二层循环：");
                    var currentElement = arr[j];
                    var nextElement = arr[j + 1];
                    if (currentElement > nextElement)
                    {
                        arr[j] = nextElement;
                        arr[j + 1] = currentElement;
                        Console.Write("");
                        ShowResult(arr);
                    }else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        static void ShowResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
