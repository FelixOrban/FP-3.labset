//Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 

namespace MergeSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("E. Vector = ");
        int[] E = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = E.Length;

        Console.Write("W. Vector = ");
        int[] W = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int m = W.Length;
        if (n != m)
        {
            Console.WriteLine("invalid Vectors");
            return;
        }

        MergeSplit(E, W, n, m);
        Console.WriteLine(string.Join(" ", E));
        Console.WriteLine(string.Join(" ", W));
    }

    static void MergeSplit(int[] E, int[] W, int n , int m)
    {
        if (n <= 1)
            return;

        int mid = n / 2;

        int[] leftE = E.Take(mid).ToArray();
        int[] rightE = E.Skip(mid).ToArray();

        int[] leftW = W.Take(mid).ToArray();
        int[] rightW = W.Skip(mid).ToArray();

        MergeSplit(leftE, leftW, leftE.Length, leftW.Length);

        MergeSplit(rightE, rightW, rightE.Length, rightW.Length);

        MergeSort(E, W, leftE, leftW, rightE, rightW);
    }

    static void MergeSort(int[] E, int[] W, int[] leftE, int[] leftW, int[] rightE, int[] rightW)
    {
        int i = 0, j = 0, k = 0;

        while (i < leftE.Length && j < rightE.Length)
        {
            if (leftE[i] < rightE[j])
                E[k++] = leftE[i++];
            else if (leftE[i] > rightE[j])
                E[k++] = rightE[j++];
            else
            {
                if (leftW[i] >= rightW[j])
                {
                    E[k] = leftE[i];
                    W[k++] = leftW[i++];
                }
                else
                {
                    E[k] = rightE[j];
                    W[k++] = rightW[j++];
                }
            }
        }

        while (i < leftE.Length)
        {
            E[k] = leftE[i];
            W[k++] = leftW[i++];
        }

        while (j < rightE.Length)
        {
            E[k] = rightE[j];
            W[k++] = rightW[j++];
        }
    }
}
