//Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

namespace InsertionSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 10;
        Random rnd = new Random();
        int[] v = new int[n];
        for (int i = 0; i < v.Length; i++)
            v[i] = rnd.Next(100);

        InsertionSort(10, v);
        Console.WriteLine(string.Join(' ', v));
    }

    static void InsertionSort(int n, int[] v)
    {
        for (int i = 1; i < n; ++i)
        {
            int temp = v[i];
            int j = i - 1;
            while (j >= 0 && v[j] > temp)
            {
                v[j + 1] = v[j];
                j--;
            }
            v[j + 1] = temp;
        }
    }
}
