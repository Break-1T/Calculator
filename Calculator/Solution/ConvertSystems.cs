using System;
using System.Collections.Generic;

namespace Calculator.Solution
{
    class ConvertSystems
    {
        public static string To2(int x)
        {
            List<int> numbers = new List<int>();
            string result = "";

            while (x >= 1)
            {
                int mod = x % 2;
                numbers.Add(mod);
                x /= 2;
            }

            numbers.Reverse();

            foreach (int i in numbers)
                result += i.ToString();

            return result;
        }
        public static string To8(int x)
        {
            List<int> numbers = new List<int>();
            string result = "";

            while (x >= 1)
            {
                int mod = x % 8;
                numbers.Add(mod);
                x /= 8;
            }

            numbers.Reverse();

            foreach (int i in numbers)
                result += i.ToString();

            return result;
        }
        public static string To16(int x)
        {
            List<int> numbers = new List<int>();
            string result = "";

            while (x >= 1)
            {
                int mod = x % 16;
                numbers.Add(mod);
                x /= 16;
            }
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (numbers[i])
                {
                    case 10:
                        result += 'A';
                        break;

                    case 11:
                        result += 'B';
                        break;

                    case 12:
                        result += 'C';
                        break;

                    case 13:
                        result += 'D';
                        break;

                    case 14:
                        result += 'E';
                        break;

                    case 15:
                        result += 'F';
                        break;
                    default:
                        result += numbers[i].ToString();
                        break;
                }
            }
            return result;
        }

        public static string From2To10(double x) //111010,1001
        {
            long WholePart=(long) x;
            long length = (x.ToString().Length - WholePart.ToString().Length)-1;
            long ModPart = (long)Math.Round((x % 10)*Math.Pow(10,length));

            double WholeSum = 0;
            double ModSum = 0;

            double result;

            List<long> WholeList = Digits(WholePart);
            List<long> ModList = Digits(ModPart);

            WholeList.Reverse();

            for(int i = 0 ; i<WholeList.Count ; i++)
            {
                if (WholeList[i] == 1)
                {
                    WholeSum += Math.Pow(2, i);
                }
            }

            for (int i = 0; i < ModList.Count; i++)
            {
                if (ModList[i] == 1)
                {
                    ModSum += Math.Pow(2, -(i+1));
                }
            }

            result = WholeSum + ModSum;

            return result.ToString();
        }

        private static List<long> Digits(long x)
        {
            List<long> input = new List<long>();
            while (x > 0)
            {
                input.Add(x % 10);
                x /= 10;
            }
            input.Reverse();
            return input;
        }
    }
}
