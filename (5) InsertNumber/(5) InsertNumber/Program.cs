//Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.

namespace InsertNumber;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Vector = ");
        int[] vector = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(n != vector.Length)
        {
            Console.WriteLine("Numarul de elemente nu corespunde cu lungimea vectorului.");
            return;
        }
        int[] vector2 = new int[n + 1];

        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if (k < 0 || k > n)
        {
            Console.WriteLine("k is not valid position");
            return;
        }

        for (int i = n - 1; i >= k; --i)
            vector2[i + 1] = vector[i];

        vector2[k] = e;

        for (int i = 0; i < k; ++i)
            vector2[i] = vector[i];

        Console.Write(String.Join(" " , vector2));
    }
}