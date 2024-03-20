using System;
using Internal;

namespace Test
{
    class FuckShit
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(300, 200);
            Console.ForegroundColor = ConsoleColor.Green;

            // Lies
            Console.WriteLine("Working on it... ");

            Random rand = new Random();

            // Dividing big numbers takes the most operations so its hella slow
            double num1 = rand.NextDouble() * (900000 - 700000) + 700000;
            double num2 = rand.NextDouble() * (900000 - 700000) + 700000;
            int  arrayLength = 2147483647;

            // This just creates an array with the int.MaxValue
            // iirc this shits like 8gb of ram alone.
            double[] nums = new double[arrayLength];

            // Infinite loop which does the division
            for(int i = 0; i >= 0; i++)
            {
                double ans = num1 / num2;
                nums[i] = ans;

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