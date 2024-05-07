using System;

namespace CS001_HelloWorld
{
    class Program     // Đây là một ghi chú 1 dòng, đặt ngay sau lệnh C#
    {
        /*

        Comment on
        many lines
        */
        static void Main(string[] args)
        {
            // Đây là một dòng ghi chú 1 dòng riêng biệt - dòng này không ảnh hưởng đến code
            Sum(21,3);

            Console.WriteLine("Welcome to C# NET CORE! Tutorial");
        }
        // This is from C# xml documentation in visual studio code
        /// <summary>
        /// Calculate sum of 2 integers
        /// </summary>
        /// <param name="a">Fist Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Return sum of first number and second number (a + b)</returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}