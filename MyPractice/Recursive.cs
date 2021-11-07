using System;
using System.Threading;
using static System.Console;

namespace MyPractice
{
    internal class Recursive
    {
        public int degreOfNumber(int degree)
        {
            int result = 1;
            int number = 2;
            //int degree = 4;
            if (degree == 1)
                return 1;
            result = degreOfNumber(degree-1) * number;
            return result;
        }

        static void main(string[] args)
        {
            int number = 2;
            int degree = 4;

            //int finalResult = degreOfNumber(degree);
            //WriteLine(finalResult);

            //degreeOfNumber = degreeOfNumber * number;
        }
    }
}