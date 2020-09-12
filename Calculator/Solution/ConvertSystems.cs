using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Calculator.Solution
{
    class ConvertSystems
    {
        public static string From10To2(double x)
        {
            long WholePart = (long)x;
            double ModPart = x - WholePart;
            Console.WriteLine(ModPart);

            List<long> WholeList = new List<long>();
            List<long> ModList = new List<long>();

            string result = "";

            //Whole Part = > WholeList
            while (WholePart >= 1)
            {
                int mod = (int)WholePart % 2;
                WholeList.Add(mod);
                WholePart /= 2;
            }
            //Mod Part = > ModList
            for(int n = 0; n < 4; n++)
            {
                double Whole = ModPart * 2;
                int temp = (int)Whole;
                ModList.Add(temp);
                ModPart = Math.Abs(temp - Whole);
            }

            WholeList.Reverse();

            for(int i = 0; i <= WholeList.Count; i++)
            {
                if (i < WholeList.Count)
                {
                    result += WholeList[i].ToString();
                }
                if (i == WholeList.Count)
                {
                    result += ",";
                }
            }

            foreach (long i in ModList)
            {
                result += i.ToString();
            }

            return result;
        }
        public static string From10To8(double x)
        {
            long WholePart = (long)x;
            double ModPart = x - WholePart;

            List<long> WholeList = new List<long>();
            List<long> ModList = new List<long>();

            string result = "";

            //Whole Part = > WholeList
            while (WholePart >= 1)
            {
                int mod = (int)WholePart % 8;
                WholeList.Add(mod);
                WholePart /= 8;
            }
            //Mod Part = > ModList
            for (int n = 0; n < 4; n++)
            {
                double Whole = ModPart * 8;
                int temp = (int)Whole;
                ModList.Add(temp);
                ModPart = Math.Abs(temp - Whole);
            }

            WholeList.Reverse();

            for (int i = 0; i <= WholeList.Count; i++)
            {
                if (i < WholeList.Count)
                {
                    result += WholeList[i].ToString();
                }
                if (i == WholeList.Count)
                {
                    result += ",";
                }
            }

            foreach (long i in ModList)
            {
                result += i.ToString();
            }

            return result;
        }
        public static string From10To16(double x)
        {
            long WholePart = (long)x;
            double ModPart = x - WholePart;

            List<long> WholeList = new List<long>();
            List<long> ModList = new List<long>();

            string result = "";

            //Whole Part = > WholeList
            while (WholePart >= 1)
            {
                int mod = (int)WholePart % 16;
                WholeList.Add(mod);
                WholePart /= 16;
            }
            //Mod Part = > ModList
            for (int n = 0; n < 4; n++)
            {
                double Whole = ModPart * 16;
                Console.Write($"\t {Whole}");
                int temp = (int)Whole;
                Console.WriteLine(temp);
                ModList.Add(temp);
                ModPart = Math.Abs(temp - Whole);
            }

            WholeList.Reverse();

            for (int i = 0; i < WholeList.Count; i++)
            {
                switch (WholeList[i])
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
                        result += WholeList[i].ToString();
                        break;
                }
            }
            result += ",";
            for (int i = 0; i < ModList.Count; i++)
            {
                switch (ModList[i])
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
                        result += ModList[i].ToString();
                        break;
                }
            }
            
            return result;
        }

        public static string From2To10(double x)
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
        public static string From8To10(double x)
        {
            long WholePart = (long)x;
            long length = (x.ToString().Length - WholePart.ToString().Length)-1;
            double ModTemp = (x-WholePart)*Math.Pow(10,length);
            long ModPart = (long)ModTemp;

            double WholeSum = 0;
            double ModSum = 0;

            double result;

            List<long> WholeList = Digits(WholePart);
            List<long> ModList = Digits(ModPart);

            WholeList.Reverse();

            for (int i = 0; i < WholeList.Count; i++)
            {
                WholeSum += WholeList[i]*Math.Pow(8, i);
            }

            for (int i = 0; i < ModList.Count; i++)
            {
                ModSum += ModList[i]*Math.Pow(8, -(i + 1));
            }

            result = WholeSum + ModSum;

            return result.ToString();
        }
        public static string From16To10(string x)
        {
            List<string> SymbolsList = new List<string>();
            char[] symbols = x.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                switch (symbols[i])
                {
                    case 'A':
                        SymbolsList.Add("10");
                        break;

                    case 'B':
                        SymbolsList.Add("11");
                        break;

                    case 'C':
                        SymbolsList.Add("12");
                        break;

                    case 'D':
                        SymbolsList.Add("13");
                        break;

                    case 'E':
                        SymbolsList.Add("14");
                        break;

                    case 'F':
                        SymbolsList.Add("15");
                        break;
                    default:
                        SymbolsList.Add(symbols[i].ToString());
                        break;
                }
            }

            int ModNumber = 0;
            // Поиск первого вхождения запятой
            foreach (string i in SymbolsList)
            {
                if (i == ".")
                    break;
                ModNumber++;
            }

            List<int> WholeList = new List<int>();
            List<int> ModList = new List<int>();

            for(int i = 0; i < SymbolsList.Count; i++)
            {
                if (i == ModNumber)
                    continue;
                if (i > ModNumber)
                {
                    ModList.Add(Convert.ToInt32(SymbolsList[i]));
                }
                else
                {
                    WholeList.Add(Convert.ToInt32(SymbolsList[i]));
                }

            }

            double WholeSum = 0;
            double ModSum = 0;

            double result;

            WholeList.Reverse();

            for (int i = 0; i < WholeList.Count; i++)
            {
                WholeSum += WholeList[i] * Math.Pow(16, i);
            }

            for (int i = 0; i < ModList.Count; i++)
            {
                ModSum += ModList[i] * Math.Pow(16, -(i + 1));
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
