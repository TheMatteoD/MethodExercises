using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodExercises
{
    internal class Exercise2
    {
        public static int AddDigits(params int[] values)
        {
            int answer = values.Sum();
            return answer;
        }

        public static int MultiplyDigits(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(MultiplyDigits(5, 0));

        }
    }
}
