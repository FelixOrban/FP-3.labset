// Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 

namespace SortedIndex;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = v.Length;

        Console.Write("Index = ");
        int index = int.Parse(Console.ReadLine()!);
        if (index < 0 || index >= n)
        {
            Console.WriteLine("index is invalid");
            return;
        }


        //bubble sort
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n - i - 1; ++j)
            {
                if (v[j] > v[j + 1])
                    (v[j], v[j + 1]) = (v[j + 1], v[j]);
            }
        }

        Console.WriteLine($"Index of the sorted vector is {v[index]}");
    }
}