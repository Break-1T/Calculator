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
            Console.WriteLine(Calculator.BinarySum(10,10000));
        }

    }
    class Calculator
    {
        public static string BinarySum(long x,long y)//111 + 10 = 1001
        {
            List<long> FirstNumbers = Digits(x);//111
            List<long> SecondNumbers = Digits(y);//10
            string result = "";
            if (FirstNumbers.Count > SecondNumbers.Count)
            {
                SecondNumbers.Reverse();
                int diff = FirstNumbers.Count - SecondNumbers.Count;
                for (int i = 0; i < diff; i++)
                    SecondNumbers.Add(0);
                SecondNumbers.Reverse();
            }
            else
            {
                FirstNumbers.Reverse();
                int diff = SecondNumbers.Count-FirstNumbers.Count;
                for (int i = 0; i < diff; i++)
                    FirstNumbers.Add(0);
                FirstNumbers.Reverse();
            }
            int length = FirstNumbers.Count;
            for(int i = length - 1; i >= 0; i--)
            {

            }

            return "";
        }
        private static List<long> Digits(long x)
        {
            List<long> input = new List<long>();
            while (x > 0)
            {
                input.Add(x%10);
                x /= 10;
            }
            input.Reverse();
            return input;
        }
    }
}
