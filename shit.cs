using System;
using Internal;

namespace Test
{
    class FuckShit
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            // Lies
            Console.WriteLine("Working on it... ");

            Random rand = new Random();

            // Dividing big numbers takes the most operations so its hella slow
            double num1 = Math.Tan(rand.NextDouble() * (900000 - 700000) + 700000);
            double num2 = Math.Tan(rand.NextDouble() * (900000 - 700000) + 700000);
            double num3 = Math.Tan(rand.NextDouble() * (900000 - 700000) + 700000);
            double num4 = Math.Tan(rand.NextDouble() * (900000 - 700000) + 700000);
            int  arrayLength = Math.Floor(2147483647 / 2);

            // This just creates an array with the int.MaxValue
            // iirc this shits like 8gb of ram alone.
            double[] nums = new double[arrayLength];

            // Infinite loop which does the division
            for(int i = 0; i >= 0; i++)
            {
                double ans1 = num1 / num2;
                double ans2 = num3 / num4;
                double finalAns = ans1 / ans2;
                nums[i] = finalAns;

                // Swaps every value in the array and divides it AGAIN
                for(int j = 0; j >= 0; j+=2)
                {
                    double temp = 0;
                    temp = nums[i];
                    nums[i] = nums[i+1];
                    nums[i+1] = temp;
                    nums[i+2] = nums[i+1] / temp; 
                }
            }
        }
    }
}
