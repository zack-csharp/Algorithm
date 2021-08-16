using Sort.Interface;

namespace Sort
{
    public class Selection : ISort
    {
        public void Sort(int[] arr)
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
