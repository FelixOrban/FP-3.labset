//Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

namespace Eratostene;
using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        bool[] isPrime = new bool[n + 1];
        isPrime[0] = false;
        isPrime[1] = false;
        for (int i = 2; i < isPrime.Length; ++i)
            isPrime[i] = true;

        for (int i = 2; i * i <= n; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                    isPrime[j] = false;
            }
        }

        for (int i = 0; i < n; ++i)
        {
            if (isPrime[i])
                Console.Write(i + " ");
        }
    }
}