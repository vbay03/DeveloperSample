using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            var result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            var result = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                var sep = i == items.Length - 1 ? " and " : ", ";
                result += sep + items[i];
            }
            return result;
        }
    }
}