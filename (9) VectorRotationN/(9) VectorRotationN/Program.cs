//Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 

namespace VectorRotation;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Vector = ");
        int[] vector = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine()!);

        int[] vector2 = new int[n];

        for (int i = 0; i < n; ++i)
            vector2[i] = vector[(i + k) % n] ;

        Console.WriteLine(string.Join(' ', vector2));

    }
}