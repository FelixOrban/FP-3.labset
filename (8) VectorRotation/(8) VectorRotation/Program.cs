//Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

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

        int[] vector2 = new int[n];

        for (int i = 0; i < n - 1; ++i)
            vector2[i] = vector[i + 1];
        vector2[n - 1] = vector[0];

        Console.WriteLine(string.Join(' ', vector2));

    }
}