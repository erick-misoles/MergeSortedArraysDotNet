using MergeSortedArrays.Helpers;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 2, 4, 6 };

            var merged = ArrayMerger.MergeSortedArrays(array1, array2);
            Console.WriteLine(string.Join(", ", merged));
        }
    }
}