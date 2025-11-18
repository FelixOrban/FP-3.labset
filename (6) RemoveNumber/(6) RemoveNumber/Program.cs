//Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 

namespace RemoveNumber;
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
        if (n != vector.Length)
        {
            Console.WriteLine("Numarul de elemente nu corespunde cu lungimea vectorului.");
            return;
        }
        int[] vector2 = new int[n - 1];

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if (k < 0 || k > n)
        {
            Console.WriteLine("k is not valid position");
            return;
        }
        for (int i = 0; i < k; ++i)
            vector2[i] = vector[i];

        for (int i = k+1; i < n; ++i)
            vector2[i - 1] = vector[i];

        Console.Write(String.Join(" ", vector2));
    }
}