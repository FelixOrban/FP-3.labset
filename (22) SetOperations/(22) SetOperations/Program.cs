///Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 

namespace SetOperations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("1. Vector = ");
        int[] v1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        Console.Write("2. Vector = ");
        int[] v2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = v1.Length;
        int m = v2.Length;
        
        //remove duplicates
        List<int> s1 = new List<int>();
        foreach (int x in v1)
        {
            if (!s1.Contains(x))
                s1.Add(x);       
        }
        List<int> s2 = new List<int>();
        foreach (int x in v2)
        {
            if (!s2.Contains(x))
                s2.Add(x);
        }

        List<int> inter = new List<int>();
        foreach(int x in s1)
        {
            if(s2.Contains(x))
                inter.Add(x);
        }

        List<int> union = new List<int>(s1);
        foreach (int x in s2)
        {
            if (!union.Contains(x))
                union.Add(x);
        }

        List<int> dif1_2 = new List<int>(s1);
        foreach (int x in s2)
        {
            if (dif1_2.Contains(x))
                dif1_2.Remove(x);
        }

        List<int> dif2_1 = new List<int>(s2);
        foreach (int x in s1)
        {
            if (dif2_1.Contains(x))
                dif2_1.Remove(x);
        }

        Console.WriteLine("Intersection : " + string.Join(" ", inter));
        Console.WriteLine("Reunion : " + string.Join(" ", union));
        Console.WriteLine("Vector 1 - Vector 2 : " + string.Join(" ", dif1_2));
        Console.WriteLine("Vector 2 - Vector 1 : " + string.Join(" ", dif2_1));
    }
}