using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if ( count < 0)
            {
                throw new ArgumentException();
            }
            int sum = 0;
            for (int step = 0; step < count; step++)
            {
                int t = number + add * step;
                sum += t;
            }
            return sum;   
        }
    }
}
