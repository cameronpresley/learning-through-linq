using System;
using System.Collections.Generic;

namespace LinqExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            new List<int>{1, 2, 3, 4, 5}
            .Where(x => x % 2 == 0)
            .Select(x=>x.ToString())
            .ForEach(Console.WriteLine);
            Console.WriteLine("Hello World!");
        }
    }
}
