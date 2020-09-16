using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Solution
{
    class Calculator
    {
        public static void GetSolution()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(
                    "Выберите номер системы счисления:\n" +
                    "1.Двоичная\n" +
                    "2.Восьмеричная\n" +
                    "3.Шестнадцатеричная");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            switch (n)
            {
                case 1:
                    Binary();
                    break;
                case 2:
                    Octal();
                    break;
                case 3:
                    Hexadecimal();
                    break;
                default:
                    return;
            }
        }

        private static void Binary()
        {
            Console.WriteLine("*Вместо символа '.' используйте ','");
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(
                "Выберите операцию:\n" +
                "1. Суммировать\n" +
                "2. Вычесть\n" +
                "3. Умножить\n" +
                "4. Разделить");

            double temp_1 = ConvertSystems.From2To10(x);
            double temp_2 = ConvertSystems.From2To10(y);

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            double result = 0;
            switch (n)
            {
                case 1:
                    result = temp_1 + temp_2;
                    break;
                case 2:
                    result = temp_1 - temp_2;
                    break;
                case 3:
                    result = temp_1 * temp_2;
                    break;
                case 4:
                    result = temp_1 / temp_2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Результат: {ConvertSystems.From10To2(result)}");
            Console.ReadKey();
        }
        private static void Octal()
        {
            Console.WriteLine("*Вместо символа '.' используйте ','");
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(
                "Выберите операцию:\n" +
                "1. Суммировать\n" +
                "2. Вычесть\n" +
                "3. Умножить\n" +
                "4. Разделить");

            double temp_1 = ConvertSystems.From8To10(x);
            double temp_2 = ConvertSystems.From8To10(y);


            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            double result = 0;
            switch (n)
            {
                case 1:
                    result = temp_1 + temp_2;
                    break;
                case 2:
                    result = temp_1 - temp_2;
                    break;
                case 3:
                    result = temp_1 * temp_2;
                    break;
                case 4:
                    result = temp_1 / temp_2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Результат: {ConvertSystems.From10To8(result)}");
            Console.ReadKey();
        }
        private static void Hexadecimal()
        {
            Console.WriteLine("*Вместо символа ',' используйте '.'");
            Console.Write("Введите первое число: ");
            string x = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string y = Console.ReadLine();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(
                "Выберите операцию:\n" +
                "1. Суммировать\n" +
                "2. Вычесть\n" +
                "3. Умножить\n" +
                "4. Разделить");

            double temp_1 = ConvertSystems.From16To10(x);
            double temp_2 = ConvertSystems.From16To10(y);


            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            double result = 0;
            switch (n)
            {
                case 1:
                    result = temp_1 + temp_2;
                    break;
                case 2:
                    result = temp_1 - temp_2;
                    break;
                case 3:
                    result = temp_1 * temp_2;
                    break;
                case 4:
                    result = temp_1 / temp_2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Результат: {ConvertSystems.From10To16(result)}");
            Console.ReadKey();
        }
    }
} 
