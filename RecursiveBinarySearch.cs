namespace RecursiveBinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };
            Console.Write("input target: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int? index = RecursiveBinarySearch(numbers, 13, 0, numbers.Length);
            Console.WriteLine(index == null ? "Target not found" : $"Target has index {index}");
        }

        static int? RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            int mid = (left + right) / 2;

            if (left > right)
            {
                return null;
            }
            if (array[mid] == target)
            {
                return mid;
            }
            if (array[mid] > target)
            {
                return RecursiveBinarySearch(array, target, left, mid - 1);
            }
            else
            {
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }
        }
    }
}