

namespace Nullable
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        public static void Triple(int x, out int result)
        {
            result = x * 3;
        }
        public static int Sum (params int[] numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }

            return sum;
        }
    }
}
