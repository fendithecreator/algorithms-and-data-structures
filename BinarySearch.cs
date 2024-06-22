namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };
            Console.Write("input target: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int? index = BinarySearch(numbers, target);
            Console.WriteLine(index == null ? "Target not found" : $"Target has index {index}");
        }

        static int? BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}