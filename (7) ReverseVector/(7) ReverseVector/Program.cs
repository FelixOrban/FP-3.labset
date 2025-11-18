//Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

namespace ReverseVector;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Vector = ");
        int[] vector = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] vector2 = new int[n];

        for(int i = 0; i<n; ++i)
            vector2[i] = vector[n - 1 - i];

        Console.WriteLine(string.Join(' ' , vector2));
    }
}