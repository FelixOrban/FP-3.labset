//Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.

namespace VectorCommonDivisor;
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
        if(n != v.Length)
        {
            Console.Write("n not equal with the lenght of the vector ");
            return;
        }

        int divisor = v[0];

        for (int i = 1; i < n; ++i)
            divisor = GCD(divisor, v[i]);

        Console.WriteLine($"Greatest Common Divisor of the vector is {divisor}");

    }
    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}