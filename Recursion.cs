namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(numbers));
        }

        static int Sum(int[] array)
        {
            int length = array.Length;
            int[] slicedArray = array.Skip(1).Take(length).ToArray();
            if (array.Length == 0) 
                return 0;
            return array[0] + Sum(slicedArray);
        }
    }
}