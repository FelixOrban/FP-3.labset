///MergeSort. Sortati un vector folosind metoda MergeSort.

namespace MergeSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = v.Length;

        MergeSplit(v, n);
        Console.WriteLine(string.Join(" ", v));
    }

    static void MergeSplit(int[] v, int n)
    {
        if (n <= 1) //splitting the vector until we have n number vectors, than merge in pairs and so on.
            return;

        int mid = n / 2;

        int[] left = v.Take(mid).ToArray();
        int[] right = v.Skip(mid).ToArray();

        MergeSplit(left, left.Length);
        
        MergeSplit(right, right.Length);

        MergeSort(v, left, right);
    }

    static void MergeSort(int[] v, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                v[k++] = left[i++];
            else
                v[k++] = right[j++];
        }

        while (i < left.Length)
            v[k++] = left[i++];

        while (j < right.Length)
            v[k++] = right[j++];
    }
}
