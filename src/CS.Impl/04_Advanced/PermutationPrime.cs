using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        private static IEnumerable<string> Permutate(string source)
        {
            if (source.Length == 1) return new List<string> { source };

            var permutations = from c in source
                               from p in Permutate(new String(source.Where(x => x != c).ToArray()))
                               select c + p;

            return permutations;
        }

        public int[] GetPermutationPrimes(int upperBound)
        {
            try
            {
                int[] result = new int[] { };
                for (int i = upperBound; i != 1; i--)
                {
                    var permutationsNumbers = Permutate(i.ToString());
                    var testPrimeOnPermutation = true;
                    foreach (string n in permutationsNumbers)
                    {
                        testPrimeOnPermutation = IsPrime(int.Parse(n)) && testPrimeOnPermutation && i.ToString().Length == n.Length; 
                    }
                    if (testPrimeOnPermutation && IsPrime(i))
                    {
                        if (!result.Contains(i))
                            result = result.Append(i).ToArray();
                        foreach (string n in permutationsNumbers)
                        {
                            var intParse = int.Parse(n);
                            if (!result.Contains(intParse))
                                result = result.Append(intParse).ToArray();
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

        private bool IsPrime(int n)
        {
            return IsPrime(n, n / 2);
        }

        private bool IsPrime(int n, int current)
        {
            if (current == 0)
            {
                return false;
            }
            if (current == 1)
            {
                return true;
            }
            else
            {
                if (n % current == 0)
                    return false;
                else
                    return IsPrime(n, current - 1);
            }
        }
    }
}
