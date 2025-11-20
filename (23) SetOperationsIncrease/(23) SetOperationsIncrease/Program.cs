//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 

namespace SetOperationsIncrease;
using System;
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
        int i = 0, j = 0;

        List<int> inter = new List<int>();
        while (i < n && j < m)
        {
            if (v1[i] == v2[j])
            {
                inter.Add(v1[i]);
                i++; j++;
            }
            else if (v1[i] < v2[j])
                i++;
            else
                j++;
        }
        Console.WriteLine("Intersection = " + string.Join(",", inter));

        i = 0; j = 0;
        List<int> union = new List<int>();
        while (i < n && j < m)
        {
            if (v1[i] < v2[j])
            {
                union.Add(v1[i]);
                i++;
            }
            else if (v1[i] > v2[j])
            {
                union.Add(v2[j]);
                j++;
            }
            else
            {
                union.Add(v1[i]);
                i++; j++;
            }
        }
        while (i < n) union.Add(v1[i++]);
        while (j < m) union.Add(v2[j++]);
        Console.WriteLine("Reunion = " + string.Join(",", union));

        i = 0; j = 0;
        List<int> dif1_2 = new List<int>();
        while (i < n && j < m)
        {
            if (v1[i] < v2[j])
            {
                dif1_2.Add(v1[i]);
                i++;
            }
            else if (v1[i] > v2[j])
                j++;
            else
                i++; j++;
        }
        while (i < n) dif1_2.Add(v1[i++]);
        Console.WriteLine("1. Vector - 2. Vector = " + string.Join(",", dif1_2));

        i = 0; j = 0;
        List<int> dif2_1 = new List<int>();
        while (i < n && j < m)
        {
            if (v2[j] < v1[i])
            {
                dif2_1.Add(v2[j]);
                j++;
            }
            else if (v2[j] > v1[i])
                i++;
            else
                i++; j++;
        }
        while (j < m) dif2_1.Add(v2[j++]);
        Console.WriteLine("2. Vector - 1. Vector = " + string.Join(",", dif2_1));
    }
}