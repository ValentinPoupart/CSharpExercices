using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            for (var i = 1001; i != 1; i--)
            {
                Console.WriteLine($"{counter++}: ");
                foreach (string str in Permutate(i.ToString()))
                {
                    Console.WriteLine($"{str}");
                }
            }
            Console.WriteLine("end");
        }

        private static IEnumerable<string> Permutate(string source)
        {
            if (source.Length == 1) return new List<string> { source };

            var permutations = from c in source
                               from p in Permutate(new String(source.Where(x => x != c).ToArray()))
                               select c + p;

            return permutations;
        }
    }
}
