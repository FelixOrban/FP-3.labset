//Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea

namespace MinManScan;
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
        int mincount = 1, maxcount = 1;

        for (int i = 1; i < n; ++i)
        {
            if (v[i] < min) 
            {
                min = v[i];
                mincount = 1;
            }
            else if (v[i] == min)
                mincount++;

            if (v[i] > max)
            {
                max = v[i];
                maxcount = 1;
            }
            else if (v[i] == max)
                maxcount++;
        }

        Console.WriteLine($"Smallest number: {min}, {mincount} times appear in the vector");
        Console.WriteLine($"Biggest number: {max}, {maxcount} times appear in the vector");
    }
}
