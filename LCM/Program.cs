using System;
namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeastCommonMultiple(3));
        }

        public static int LeastCommonMultiple(int n)
        {
            int sum = 0;

            for (int i =1; i<= n; i++)
            {
                sum += LeastCommonMultiple(i, n);
            }
            return sum;
        }

        public static int LeastCommonMultiple(int value1, int value2)
        {
            int maxValue = Math.Max(value1, value2);
            for (int i = maxValue; i <= 10000; i++ ){
                if (i % value1 == 0 && i% value2 == 0)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
