// Lab_05_3.cs
// Якубовський Владислав
// Лабораторна робота № 5.3 
// Функції, що містять розгалуження та цикли з рекурентними співвідношеннями.
// Варіант 24
using System;
using static System.Math;

namespace AP_Lab_05_3
{
    public class Lab_05_3
    {
        public static double F(double x)
        {
            if (Abs(x) >= 1)
                return Sin(x / 2) / (1 + Pow(Cos(x), 2));

            else
            {
                int ii = 0;
                double a = 1, sum = a;

                do
                {
                    ii++;

                    double R = Pow(x, 2) / (3 * ii * (3 * ii - 1) * (3 * ii - 2));               
                                        
                    a *= R;
                    sum += a;

                } while (ii <= 6);

                return sum;
            }
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть значення змінних \"y початкове\", \"y кінцеве\", \"n\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double yInital = Double.Parse(varArray[0].Replace('.', ',')),
            yFinal = Double.Parse(varArray[1].Replace('.', ',')),
            dy = (yFinal - yInital) / Double.Parse(varArray[2].Replace('.', ',')),
            g;

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+\n" +
                "|\ty\t|\tg\t|\n" +
                "+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (double y = yInital; y <= yFinal; y += dy)
            {
                g = F(1 + Sqrt(y) + y) + Pow(F(1 + F(1) + Pow(F(Sqrt(y)), 2)), 2);

                Console.WriteLine($"|\t{y:0.####}\t|\t{g:0.####}\t|\n" +
                    $"+---------------+---------------+");
            }

            Console.ReadLine();
        }
    }
}