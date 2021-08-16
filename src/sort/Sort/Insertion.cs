using Sort.Interface;

namespace Sort
{
    public class Insertion : ISort
    {
        public void Sort(int[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 1; i < arrLength; i++)
            {
                int previousIndex = i - 1;
                int currentElement = arr[i];

                while (previousIndex >= 0 && arr[previousIndex] > currentElement)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex--;
                }

                arr[previousIndex + 1] = currentElement;
            }
        }
    }
}
