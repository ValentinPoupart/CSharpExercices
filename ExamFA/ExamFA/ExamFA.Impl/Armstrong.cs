using System;

namespace ExamFA.Impl
{
    public class Armstrong
    {
        public bool IsArmstrong(int input)
        {
            var sum = 0;
            for (int i = input; i > 0; i = i / 10)
            {
                sum += ((i % 10) * (i % 10) * (i % 10));
            }
            return sum == input;
        }
    }
}
