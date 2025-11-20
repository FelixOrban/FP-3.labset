//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).

namespace SetOperationsBinary;
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
        List<int> inter = new List<int>();
        List<int> uni = new List<int>();
        List<int> dif1_2 = new List<int>();
        List<int> dif2_1 = new List<int>();

        int i = 0;
        while (i < Math.Min(n, m))
        {
            inter.Add(v1[i] & v2[i]);
            uni.Add(v1[i] | v2[i]);
            dif1_2.Add(v1[i] & (v2[i] == 1 ? 0 : 1));
            dif2_1.Add(v2[i] & (v1[i] == 1 ? 0 : 1));
            i++;
        }

        //rest, if one vector is shorter than the other 
        int j = i;
        while (j < n)
        {
            uni.Add(v1[j]);
            dif1_2.Add(v1[j]);
            j++;
        }

        j = i;
        while (j < m)
        {
            uni.Add(v2[j]);
            dif2_1.Add(v2[j]);
            j++;
        }

        Console.WriteLine("Intersection = " + string.Join(",", inter));
        Console.WriteLine("Union = " + string.Join(",", uni));
        Console.WriteLine("v1 - v2 = " + string.Join(",", dif1_2));
        Console.WriteLine("v2 - v1 = " + string.Join(",", dif2_1));

    }
}