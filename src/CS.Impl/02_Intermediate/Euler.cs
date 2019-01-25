using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Impl._02_Intermediate
{
    public class Euler
    {
        //public int SmallestMultiple(int max, int value = 1)
        //{
        //    if (IsDivisible(max, value))
        //        return value;
        //    else
        //        return SmallestMultiple(max, value + 1);
        //}

        public bool IsDivisible(int max, int value)
        {
            for (int i = 2; i != max; i++)
            {
                int testDivision = value % i;
                if (testDivision != 0)
                    return false;
            }
            return true;
        }

        public int SmallestMultiple(int max, int value = 1)
        {
            try
            {
                while (!IsDivisible(max, value))
                {
                    value++;
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
