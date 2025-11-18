//Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.

namespace SelectionSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n=10;
        Random rnd = new Random();
        int[] v = new int[n];
        for (int i = 0; i < v.Length; i++)
        v[i] = rnd.Next(100);

        SelectionSort(10, v);
        Console.WriteLine(string.Join(' ' , v));
    }

    static void SelectionSort(int n, int[] v)
    {
        for(int i= 0; i< n; ++i)
        {
            int min = i;
            for(int j=i+1; j < n; ++j)
            {
                if (v[j] < v[min])
                    min = j;
            }

            (v[i], v[min]) = (v[min], v[i]);
        }
    }
}