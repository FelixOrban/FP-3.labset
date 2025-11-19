//Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

namespace VectorSingleTime;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        if (n != v.Length)
        {
            Console.WriteLine("n is not equal with the lenght of the vector");
            return;
        }

        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                if (v[j] == v[i])
                {
                    for (int k = j; k < n - 1; ++k)
                        v[k] = v[k + 1];

                    n--;
                    j--; //for not skipping
                }
            }
        }

        for(int i = 0; i < n; ++i)
            Console.Write(v[i] + " ");
    }
}