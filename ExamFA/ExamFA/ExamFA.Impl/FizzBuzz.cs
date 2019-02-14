using System;

namespace ExamFA.Impl
{
    public class FizzBuzz
    {
        public string Analyze(int input)
        {
            var output = "";
            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";

            return output;
        }
    }
}
