﻿using System.Diagnostics.CodeAnalysis;

namespace yoyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] two = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < two.Length; i++)
            {
                sum += two[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum*2);
            Console.WriteLine(sum*3); //nigger

        }
    }
}
