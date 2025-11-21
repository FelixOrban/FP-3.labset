//Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 

namespace HugeNumbers;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("First number = ");
        string input1 = Console.ReadLine()!;
        int[] v1 = input1.Select(x => x - '0').ToArray(); 
        int n = v1.Length;

        Console.Write("Second number = ");
        string input2 = Console.ReadLine()!;
        int[] v2 = input2.Select(y=> y - '0').ToArray();
        int m = v2.Length;

        

    }
}
