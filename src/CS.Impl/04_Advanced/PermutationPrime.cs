using System;
using System.Linq;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {
            try
            {
                int[] result = new int[] { };
                for (int i = 2; i != upperBound; i++)
                {
                    var permutationsNumbers = PermutationsNumbers(i);
                    foreach (int n in permutationsNumbers)
                    {
                        IsPrime(n) ? continue : break;
                    }
                    if (IsPrime(i) && )
                    {
                        result.Append(i);
                        result.Concat(permutationsNumbers);
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        void permute(char* a, int l, int r)
        {
            int i;
            if (l == r)
                printf("%s\n", a);
            else
            {
                for (i = l; i <= r; i++)
                {
                    swap((a + l), (a + i));
                    permute(a, l + 1, r);
                    swap((a + l), (a + i)); //backtrack 
                }
            }
        }

        private int[] PermutationNumber(int n)
        {

        }

        private bool IsPrime(int n)
        {
            return IsPrime(n, n / 2);
        }

        private bool IsPrime(int n, int current)
        {
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
