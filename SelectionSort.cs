namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2, 7, 5, 13, 4, 0, -3, 1, 8 };
            SelectionSort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n -1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}