//Quicksort. Sortati un vector folosind metoda QuickSort. 

namespace QuickSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = v.Length;

        QuickSort(v, 0, n-1);
        Console.WriteLine(string.Join(" ", v));
    }

    static void QuickSort(int[] v, int left, int right)
    {
        if (left >= right) return;

        int pivot = v[right]; // pivot in the right side
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (v[j] <= pivot)
            {
                (v[i], v[j]) = (v[j], v[i]); // every number smaller then the pivot is going in the left side, the bigger numbers at the right side of the pivot
                i++;
            }
        }

        (v[i], v[right]) = (v[right], v[i]); //we put the pivot in the place

        QuickSort(v, left, i - 1);  // left side
        QuickSort(v, i + 1, right); // right side
        //the algorithm after we splited in 2 sides, it goes the deepest point of the left side,
        //then coming back until can go 1 time in the right side, and again going the deepest left point and so on..
    }
}
