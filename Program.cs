using System;
using System.Linq;
 
namespace FizzBuzz
{
    class Program
    {
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
 
        // 3で割り切れるか判定
        private static bool Fizz(int currentNum)
        {
            return currentNum % 3 == 0;
        }
 
        // 5で割り切れるか判定
        private static bool Buzz(int currentNum)
        {
            return currentNum % 5 == 0;
        }
 
        // 15で割り切れるか判定
        private static bool FizzBuzz(int currentNum)
        {
            return currentNum % 15 == 0;
        }
 
        // コンソールに表示
        private static void ConsoleDisplay(string value)
        {
            Console.WriteLine(value);
        }
    }
}