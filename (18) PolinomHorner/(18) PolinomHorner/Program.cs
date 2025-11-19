//Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 

namespace PolinomHorner;
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

        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine()!);

        int result = v[n];

        for (int i = n-1; i >= 0; --i)
            result = result * x + v[i]; //Horner, P(x)=((an​)x+an−1​)x+an−2​⋯+a0​

        Console.WriteLine($"{result}");
    }
}
