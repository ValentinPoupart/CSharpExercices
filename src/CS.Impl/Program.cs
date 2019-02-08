using CS.Impl._04_Advanced;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl
{
    class Program
    {
        static void Main(string[] args)
        {
            PermutationPrime prime = new PermutationPrime();
            Console.WriteLine($"{prime.GetPermutationPrimes(100)}");
            Console.WriteLine($"end");
        }
        
    }
}
