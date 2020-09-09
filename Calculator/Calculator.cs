using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    //Скласти алгоритм(блок-схему) та програму для виконання основних арифметичних операцій
    //(додавання, віднімання, множення та ділення) 
    //в різних системах числення(двійковій, вісімковій та шістнадцятковій).
    class Calculator
    {
        public static string BinarySum(long x,long y)//101 + 10 = 111
        {
            List<long> FirstNumbers = Digits(x);//111
            List<long> SecondNumbers = Digits(y);//10
            List<long> result = new List<long>();
            string end = "";

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
            int n = 0;
            for(int i = length - 1; i >= 0; i--)
            {
                bool RankTransfer = false;
                if ((FirstNumbers[i] + SecondNumbers[i]) == 2)
                {
                    RankTransfer = true;
                    result.Add(0);
                    string temp = (FirstNumbers[i] + 1).ToString();
                }
                if (RankTransfer == true)
                {
                    result.Add((FirstNumbers[i+1] +1));
                }
                else
                {
                    result.Add((FirstNumbers[i] + SecondNumbers[i]));
                }
            }
            result.Reverse();
            foreach (long i in result)
                end += i;
            return end;
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
