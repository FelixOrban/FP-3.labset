//Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

namespace MinManPairwise;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("vector numbers between spaces: ");
        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (n != v.Length)
        {
            Console.WriteLine("The number of elements does not match n.");
            return;
        }

        int min = v[0], max = v[0];
        int minpos = 0, maxpos = 0;
        int i = (n % 2 == 0) ? 0 : 1;

        for (; i < n - 1; i += 2)
        {
            int a = v[i], b = v[i + 1];

            int small = (a < b) ? a : b; // 1. comparison
            int big = (a > b) ? a : b; // still 1. comparison

            int smallpos = (a < b) ? i : i + 1;
            int bigpos = (a > b) ? i : i + 1;

            if (small < min) // 2. comparison
            { 
                min = small;
                minpos = smallpos;
            }
            if (big > max) // 3. comparison
            {
                max = big;
                maxpos = bigpos;
            }

            // Total of 3 comparisons for every 2 elements -> 3n/2
        }

        Console.WriteLine($"Smallest number: {min}, position: {minpos}");
        Console.WriteLine($"Biggest number: {max}, position: {maxpos}");
    }
}
