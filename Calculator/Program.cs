using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    //Скласти алгоритм(блок-схему) та програму для виконання основних арифметичних операцій
    //(додавання, віднімання, множення та ділення) 
    //в різних системах числення(двійковій, вісімковій та шістнадцятковій).
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    class Calculator
    {
        public static string BinarySum(long x,long y)
        {
            long[] FirstNumbers = Digits(x);
            long[] SecondNumbers = Digits(y);
            string result = "";
            if (FirstNumbers.Length > SecondNumbers.Length)
            {
                for(long i=FirstNumbers.Length-1; i>=0; i--)
                {

                }
            }

            return "";
        }
        private static long[] Digits(long x)
        {
            List<long> input = new List<long>();
            while (x > 0)
            {
                input.Add(x%10);
                x /= 10;
            }
            input.Reverse();
            return input.ToArray();
        }
    }
}
