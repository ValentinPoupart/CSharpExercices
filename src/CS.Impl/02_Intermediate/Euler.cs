using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Impl._02_Intermediate
{
    public class Euler
    {
        //public long SmallestMultiple(long max, long value = 1)
        //{
        //    if (IsDivisible(max, value))
        //        return value;
        //    else
        //        return SmallestMultiple(max, value + 1);
        //}

        public bool IsDivisible(long max, long value)
        {
            for (long i = 2; i != max; i++)
            {
                long testDivision = value % i;
                if (testDivision != 0)
                    return false;
            }
            return true;
        }

        public long SmallestMultiple(long max, long value = 0)
        {
            try
            {
                while (!IsDivisible(max, value))
                {
                    value += max;
                }
                return value;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
