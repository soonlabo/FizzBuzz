using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        /// <summary>
        /// FizzBuzz
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (int currentNum in Enumerable.Range(1,100))
            {
                if (FizzBuzz(currentNum))
                {
                    ConsoleDisplay("FizzBuzz");
                }
                else if (Fizz(currentNum))
                {
                    ConsoleDisplay("Fizz");
                }
                else if (Buzz(currentNum))
                {
                    ConsoleDisplay("Buzz");
                }
                else
                {
                    ConsoleDisplay(currentNum.ToString());
                }
            }
        }

        /// <summary>
        /// 3で割り切れるか判定
        /// </summary>
        /// <param name="currentNum">現在値</param>
        /// <returns></returns>
        private static bool Fizz(int currentNum)
        {
            if (currentNum % 3 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 5で割り切れるか判定
        /// </summary>
        /// <param name="currentNum">現在値</param>
        /// <returns></returns>
        private static bool Buzz(int currentNum)
        {
            if (currentNum % 5 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 15で割り切れるか判定
        /// </summary>
        /// <param name="currentNum">現在値</param>
        /// <returns></returns>
        private static bool FizzBuzz(int currentNum)
        {
            if (currentNum % 15 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// コンソールに表示
        /// </summary>
        /// <param name="value">表示する値</param>
        private static void ConsoleDisplay(string value)
        {
            Console.WriteLine(value);
        }
    }
}
