namespace MergeSortedArrays.Helpers
{
    public static class ArrayMerger
    {
        public static T[] MergeSortedArrays<T>(T[] array1, T[] array2) where T : IComparable<T>
        {
            if (array1 == null) throw new ArgumentNullException(nameof(array1));
            if (array2 == null) throw new ArgumentNullException(nameof(array2));

            T[] result = new T[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i].CompareTo(array2[j]) <= 0)
                    result[k++] = array1[i++];
                else
                    result[k++] = array2[j++];
            }

            while (i < array1.Length) result[k++] = array1[i++];
            while (j < array2.Length) result[k++] = array2[j++];

            return result;
        }
    }
}
