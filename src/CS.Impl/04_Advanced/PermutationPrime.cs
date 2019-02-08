using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        private static IEnumerable<string> permutations = new List<string>();

        private void WordPermuatation(string prefix, string word)
        {
            int n = word.Length;
            if (n == 0) {
                permutations = permutations.Append(prefix);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    WordPermuatation(prefix + word[i], word.Substring(0, i) + word.Substring(i + 1, n - (i + 1)));
                }
            }
        }

        public int[] GetPermutationPrimes(int upperBound)
        {
            try
            {
                int[] result = new int[] { };
                for (int i = upperBound; i != 1; i--)
                {
                    Console.WriteLine($"===========================");
                    Console.WriteLine($"{i}: ");
                    permutations = new List<string>();
                    WordPermuatation("", i.ToString());
                    var testPrimeOnPermutation = true;
                    if (IsPrime(i))
                    {
                        Console.WriteLine($"{i} prime ");
                        foreach (string n in permutations)
                        {
                            testPrimeOnPermutation = IsPrime(int.Parse(n)) && testPrimeOnPermutation;
                            Console.WriteLine($"{n} is {testPrimeOnPermutation}");
                        }
                        if (testPrimeOnPermutation)
                        {
                            if (!result.Contains(i))
                                result = result.Append(i).ToArray();
                            foreach (string n in permutations)
                            {
                                var intParse = int.Parse(n);
                                if (!result.Contains(intParse))
                                    result = result.Append(intParse).ToArray();
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
